import os
import re
import sys
from pathlib import Path

# Renkli çıktı için ANSI kodları (Windows'ta çalışır)
class Colors:
    HEADER = '\033[95m'
    OKBLUE = '\033[94m'
    OKGREEN = '\033[92m'
    WARNING = '\033[93m'
    FAIL = '\033[91m'
    ENDC = '\033[0m'
    BOLD = '\033[1m'

class StrategyAuditor:
    def __init__(self, strategies_dir):
        self.strategies_dir = Path(strategies_dir)
        self.reports = {}
        
        # Riskli Patternler (Look-Ahead Bias ve diğerleri) - DÜZELTİLDİ
        self.lookahead_patterns = [
            r"\.shift\(-\d+\)",           # Gelecekteki veriyi getirme (shift negative)
            r"\.iloc\[\s*\w*.*?\+.*?\]",  # İleriye kaydırma
        ]
        
        self.static_risk_patterns = [
            r"commission\s*=\s*\d+(\.\d+)?",
            r"lot_size\s*=\s*\d+",
            r"stop_loss\s*=\s*\d+(\.\d+)?",
            r"take_profit\s*=\s*\d+(\.\d+)?",
        ]

    def scan_file(self, filepath):
        report = {
            "file": str(filepath),
            "issues": [],
            "warnings": []
        }

        if not filepath.exists():
            return {"file": str(filepath), "error": "Dosya bulunamadı."}

        try:
            content = filepath.read_text(encoding='utf-8')
            lines = content.splitlines()
            
            # 1. Look-Ahead Bias (Geleceği Görme) Kontrolü
            for i, line in enumerate(lines, 1):
                # Negatif shift kontrolü (shift(-1), shift(-2) -> Geleceği getirir)
                if re.search(r"\.shift\(\s*-\d+", line):
                    report["issues"].append({
                        "line": i,
                        "type": "CRITICAL: LOOK-AHEAD BIAS",
                        "message": f"Gelecek veriyi çekiyor (shift(-n)): {line.strip()[:80]}...",
                        "code": line.strip()
                    })

                # Ilindex ile ileriye erişim kontrolü (Örnek: i+1, next_index)
                if re.search(r"\.iloc\[\s*\w+\s*\+", line) or re.search(r"\.iloc\[\s*\d+\s*\+", line):
                    report["warnings"].append({
                        "line": i,
                        "type": "WARNING: POTENTIAL LOOK-AHEAD",
                        "message": f"İleriye kaydırma ihtimali var (iloc index + ...): {line.strip()[:80]}...",
                        "code": line.strip()
                    })

                # Gelecek veriyi bfill ile doldurma (Büyük hata)
                if re.search(r"\.bfill\(", line):
                    report["issues"].append({
                        "line": i,
                        "type": "CRITICAL: DATA LEAKAGE",
                        "message": f"backfill kullanıldı! Geleceğin verisi şimdiki boşluklara doldurulur. {line.strip()[:80]}...",
                        "code": line.strip()
                    })

            # 2. Statik Risk Parametreleri Kontrolü
            for i, line in enumerate(lines, 1):
                for pattern in self.static_risk_patterns:
                    if re.search(pattern, line, re.IGNORECASE):
                        report["warnings"].append({
                            "line": i,
                            "type": "WARNING: STATIC RISK PARAMETER",
                            "message": f"Sabit değer kullanımı tespit edildi (Dinamik yapılmalı): {pattern}",
                            "code": line.strip()
                        })

            # 3. Numba (@njit) Güvenliği Kontrolü
            if "@njit" in content:
                report["warnings"].append({
                    "line": 0,
                    "type": "INFO: NUMBA USAGE",
                    "message": "Numba kullanımı tespit edildi. Tip güvenliği kontrol edilmelidir.",
                    "code": ""
                })

        except Exception as e:
            report["error"] = str(e)
            
        return report

    def run_audit(self):
        print(f"{self.colors.BOLD}🔍 İdealQuant Güvenlik Denetçisi Başlatılıyor...{self.colors.ENDC}")
        print(f"Taranan Dizin: {self.strategies_dir}\n")

        # Python dosyalarını bul
        files = list(self.strategies_dir.glob("*.py"))
        
        if not files:
            print(f"{Colors.FAIL}HATA: '{self.strategies_dir}' klasöründe .py dosyası bulunamadı.{Colors.ENDC}")
            return

        total_issues = 0
        total_warnings = 0

        for file in sorted(files):
            report = self.scan_file(file)
            
            if "error" in report and report["error"]:
                print(f"{Colors.FAIL}[HATA] {file.name}: {report['error']}{Colors.ENDC}")
                continue

            issues = report.get("issues", [])
            warnings = report.get("warnings", [])
            
            critical_count = len([x for x in issues if "CRITICAL" in x["type"]])
            warning_count = len(warnings)
            
            if critical_count > 0 or warning_count > 0:
                print(f"{Colors.BOLD}🔍 Denetleniyor: {file.name}{Colors.ENDC}")
                
                for issue in issues:
                    print(f"{Colors.FAIL}[{issue['type']}] Satır {issue['line']}: {issue['message']}{Colors.ENDC}")
                    # print(f"    -> {issue['code']}")
                    total_issues += 1

                for warn in warnings:
                    print(f"{Colors.WARNING}[{warn['type']}] Satır {warn['line']}: {warn['message']}{Colors.ENDC}")
                    total_warnings += 1
                
                print("-" * 40)

        print(f"\n{Colors.HEADER}DENETİM SONUÇLARI{Colors.ENDC}")
        print(f"Toplam Dosya: {len(files)}")
        print(f"{Colors.FAIL}{total_issues} Kritik Sorun (Look-Ahead Bias, Veri Sızıntısı){Colors.ENDC}")
        print(f"{Colors.WARNING}{total_warnings} Uyarı (Sabit Parametreler, Riskli Kodlar){Colors.ENDC}")
        
        if total_issues > 0:
            print(f"\n{Colors.BOLD}⚠️ DİKKAT: Kritik güvenlik açıkları tespit edildi! Backtest sonuçları sahte olabilir.{Colors.ENDC}")
            print("Öncelikle 'CRITICAL' uyarılarını giderin.")
        else:
            print(f"\n{Colors.OKGREEN}✅ Temiz görünüyor. Ancak manuel kontrol her zaman önerilir.{Colors.ENDC}")

# Renkler objesine erişim için düzeltme (Sınıf dışarıdan tanımlı ama metod içinde self.colors olarak çağrılmadı)
# Metodun içinde Colors sınıfını direkt kullanıyoruz, yukarıdaki hata düzeltildi.
StrategyAuditor.colors = Colors 

if __name__ == "__main__":
    # Proje kök dizininden strategies klasörünü hedefleyelim
    script_dir = Path(__file__).parent
    # Eğer dosya ana dizindeyse ve src/strategies varsa:
    strategies_path = script_dir / "src" / "strategies"
    
    if not strategies_path.exists():
        # Alternatif olarak direkt ana dizindeki py dosyalarını da kontrol edelim (test için)
        print(f"{Colors.WARNING}UYARI: 'src/strategies' bulunamadı. Ana klasördeki py dosyalarını taranacak.{Colors.ENDC}")
        strategies_path = script_dir
    
    auditor = StrategyAuditor(strategies_path)
    auditor.run_audit()