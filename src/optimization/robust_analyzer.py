import pandas as pd
import numpy as np
import os
import sys
from datetime import datetime

# Uygulama dizinini path'e ekle
sys.path.append(os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))
from optimization.fitness import calculate_robust_fitness

class RobustAnalyzer:
    def __init__(self, file_path):
        self.file_path = file_path
        self.raw_df = None
        self.processed_df = None
        self.param_cols = []
        
    def load_and_parse(self):
        print(f"Loading {self.file_path}...")
        if self.file_path.endswith('.xlsx'):
            df = pd.read_excel(self.file_path)
        else:
            df = pd.read_csv(self.file_path, sep=';', encoding='utf-8')
            
        df.columns = df.columns.str.strip()
        
        # 'Açıklama' parse işlemi
        # "TOMA_P , TOMA_Y , HH , ... , 1 , 2,9 , 6"
        import re
        def parse_aciklama(row):
            acik = str(row['Açıklama']).strip()
            
            # 1. Delimiter Tespiti: İdeal genelde " , " (boşluklu virgül) kullanır.
            # Eğer bu varsa, virgüllü ondalık sayıları bozmamak için bunu kullanmalıyız.
            if " , " in acik:
                parts = [p.strip() for p in acik.split(' , ') if p.strip()]
            else:
                # Boşluklu virgül yoksa, standart virgül mü bak?
                # Ama ondalık ayracı olarak virgül kullanılmış mı kontrol et.
                # Eğer "1,5" gibi bir sayı varsa ve delimiter "," ise işimiz zor.
                # Genelde dot (.) kullanılıyorsa standart virgül delimiter'dır.
                parts = [p.strip() for p in re.split(r',', acik) if p.strip()]
            
            # Parametre isimlerini ve değerlerini ayır
            names = []
            vals = []
            for p in parts:
                try:
                    # Virgüllü sayı mı? 2,9 -> 2.9
                    v = float(p.replace(',', '.'))
                    vals.append(v)
                except ValueError:
                    names.append(p)
            
            # SENARYO 1: N isim, N değer (Örn: P1, P2, 1, 2)
            if len(names) > 0 and len(vals) == len(names):
                return pd.Series(vals, index=names)
            
            # SENARYO 2: N isim, M değer (Eksik veya fazla isim)
            # Tüm sayıları her ihtimale karşı dön
            return pd.Series(vals, index=[f"V{i+1}" for i in range(len(vals))])



        print("Parsing parameter strings...")
        params_df = df.apply(parse_aciklama, axis=1)
        self.param_cols = params_df.columns.tolist()
        
        # Verileri birleştir
        df = pd.concat([df, params_df], axis=1)
        
        print("\nParsed Params Example:")
        print(params_df.head(2))
        print("\nParam Cols:", self.param_cols)
        
        # Sayısal metrikleri temizle

        metric_cols = ['Kar Zarar', 'MaxDD', 'Toplam İşlem', 'Profit Factor', 'Karlılık']
        for col in metric_cols:
            if col in df.columns:
                # pandas numeric conversion (handle turkish decimal comma)
                df[col] = df[col].astype(str).str.replace(',', '.').replace('nan', np.nan)
                df[col] = pd.to_numeric(df[col], errors='coerce')
        
        # NaN temizliği - Sadece metrikleri ve parametreleri kontrol et
        # Ama önce param_cols bos mu bak
        if not self.param_cols:
             print("ERROR: No parameters could be parsed from 'Açıklama'!")
             
        self.raw_df = df.dropna(subset=['Kar Zarar', 'Profit Factor'] + self.param_cols)
        print(f"Total valid rows after cleaning: {len(self.raw_df)}")

    def run_robust_analysis(self):
        print("Running Robustness Suite (Clustering & Neighbors)...")
        # calculate_robust_fitness fonksiyonumuz dict listesi bekliyor
        results_list = self.raw_df.to_dict('records')
        
        # Bizim fitness motorumuz 'fitness' anahtarı arar. Kar Zarar'ı fitness olarak ata.
        for r in results_list:
            r['fitness'] = r['Kar Zarar']
            
        # Analitiği çalıştır
        analyzed_results = calculate_robust_fitness(results_list, param_keys=self.param_cols)
        
        if not analyzed_results:
            print("ERROR: Analyzed results list is empty!")
            return
            
        print(f"Sample keys from result: {list(analyzed_results[0].keys())}")
        self.processed_df = pd.DataFrame(analyzed_results)
        
        if 'robust_fitness' not in self.processed_df.columns:
            print("ERROR: 'robust_fitness' column MISSING from analyzed results!")
            return
            
        # Normalize Robustness Score (0-100)
        max_rf = self.processed_df['robust_fitness'].max()

        if max_rf > 0:
            self.processed_df['RobustScore'] = (self.processed_df['robust_fitness'] / max_rf) * 100
        else:
            self.processed_df['RobustScore'] = 0
            
        # RobustScore'a göre sırala
        self.processed_df = self.processed_df.sort_values(by='RobustScore', ascending=False)

    def export_report(self, output_path=None):
        if output_path is None:
            timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
            output_path = f"D:\\Projects\\IdealQuant\\data\\optimizasyon_robust_analiz_{timestamp}.xlsx"
            
        print(f"Exporting full report to {output_path}...")
        
        # Özet tablo: Cluster bazlı analiz
        cluster_summary = self.processed_df.groupby('cluster').agg({
            'Kar Zarar': ['mean', 'max', 'count'],
            'Profit Factor': 'mean',
            'RobustScore': 'mean'
        }).reset_index()
        
        with pd.ExcelWriter(output_path, engine='xlsxwriter') as writer:
            # Sheet 1: Tüm Sonuçlar (En Robust Olanlar Üstte)
            self.processed_df.to_excel(writer, sheet_name='Robust_Ranking', index=False)
            
            # Sheet 2: Cluster Özetleri
            cluster_summary.to_excel(writer, sheet_name='Cluster_Summary')
            
            # Actionable: En İyi 3 Kümenin Merkezi (Önerilen Parametreler)
            best_clusters = cluster_summary.sort_values(('RobustScore', 'mean'), ascending=False).head(3)['cluster'].tolist()
            recommendations = []
            for cid in best_clusters:
                c_df = self.processed_df[self.processed_df['cluster'] == cid]
                # Küme içindeki en yüksek RobustScore'a sahip satırı al
                best_set = c_df.iloc[0][self.param_cols].to_dict()
                best_set['Cluster'] = cid
                best_set['Avg_Profit'] = c_df['Kar Zarar'].mean()
                best_set['Avg_Robustness'] = c_df['RobustScore'].mean()
                recommendations.append(best_set)
            
            pd.DataFrame(recommendations).to_excel(writer, sheet_name='RECOMMENDED_PARAMS')

        print("DONE! Lütfen Excel dosyasını kontrol edin.")
        return output_path

if __name__ == "__main__":
    # Test: Kitap3.xlsx
    analyzer = RobustAnalyzer(r"D:\Projects\IdealQuant\data\Kitap3.xlsx")
    analyzer.load_and_parse()
    analyzer.run_robust_analysis()
    analyzer.export_report()
