import pandas as pd
from sklearn.ensemble import RandomForestClassifier
from sklearn.model_selection import TimeSeriesSplit, cross_val_score
from sklearn.metrics import classification_report, confusion_matrix, accuracy_score, roc_auc_score
import os
import joblib

# gap_labeler.py ile senkronize özellik listesi
FEATURES = [
    'Gap_Yuzde',
    'Gap_Yon_Binary',
    'Volatility_Std',
    'Volume_Change',
    'Gun_Sira',
    'Pre_Trend_5Gun',
    'Gap_Kategori',
    'Ilk5Bar_Yonu',
]

def train_gap_model(dataset_path):
    print(f"[*] Veri seti okunuyor: {dataset_path}")
    if not os.path.exists(dataset_path):
        return f"Hata: {dataset_path} bulunamadı."

    try:
        df = pd.read_csv(dataset_path, sep=';', decimal=',')
    except Exception as e:
        return f"Veri okuma hatası: {e}"

    if df.empty:
        return "Hata: Veri seti boş."

    # Zaman serisi split için tarih sırası zorunlu
    df = df.sort_values('Gap_Tarihi').reset_index(drop=True)

    # Eksik özellik kontrolü — eski veri setiyle geriye dönük uyumluluk
    available_features = [f for f in FEATURES if f in df.columns]
    missing = set(FEATURES) - set(available_features)
    if missing:
        print(f"[!] Uyarı: Şu özellikler eksik (eski veri seti): {missing}")
        print("    Lütfen gap_labeler.py'yi yeniden çalıştırarak güncel veri seti oluşturun.")

    X = df[available_features]
    y = df['Target_Label']

    label_counts = y.value_counts()
    print(f"[*] Toplam örnek: {len(df)} | Özellik: {len(available_features)}")
    print(f"    Label=0 (Gap Kapandı): {label_counts.get(0, 0)} | Label=1 (Trend Devam): {label_counts.get(1, 0)}")

    # ----------------------------------------------------------------
    # KRONOLOJİK SPLIT — zaman sırası korunur, veri sızıntısı engellenir
    # %80 eğitim | %20 test  (rastgele değil!)
    # ----------------------------------------------------------------
    split_idx = int(len(df) * 0.8)
    X_train, X_test = X.iloc[:split_idx], X.iloc[split_idx:]
    y_train, y_test = y.iloc[:split_idx], y.iloc[split_idx:]
    print(f"[*] Eğitim: {len(X_train)} örnek (kronolojik) | Test: {len(X_test)} örnek")

    print("[*] Model eğitiliyor (Random Forest)...")
    model = RandomForestClassifier(
        n_estimators=300,
        max_depth=6,
        min_samples_leaf=5,
        class_weight='balanced',   # Sınıf dengesizliğini dengeler
        random_state=42,
        n_jobs=-1
    )
    model.fit(X_train, y_train)

    # Tahmin ve değerlendirme
    y_pred = model.predict(X_test)
    y_prob = model.predict_proba(X_test)[:, 1]

    print("\n--- MODEL PERFORMANS RAPORU ---")
    print(f"Doğruluk (Accuracy) : {accuracy_score(y_test, y_pred):.4f}")
    try:
        print(f"ROC-AUC             : {roc_auc_score(y_test, y_prob):.4f}")
    except Exception:
        pass
    print("\nKarmaşıklık Matrisi:")
    print(confusion_matrix(y_test, y_pred))
    print("\nSınıflandırma Raporu:")
    print(classification_report(y_test, y_pred))

    # Özellik önem düzeyleri
    feat_df = pd.DataFrame({
        'Özellik': available_features,
        'Önem':    model.feature_importances_
    }).sort_values('Önem', ascending=False)
    print("\n--- ÖZELLİK ÖNEM DÜZEYLERİ ---")
    print(feat_df.to_string(index=False))

    # ----------------------------------------------------------------
    # ZAMAN SERİSİ CROSS-VALIDATION (5-fold)
    # ----------------------------------------------------------------
    tscv = TimeSeriesSplit(n_splits=5)
    cv_scores = cross_val_score(model, X, y, cv=tscv, scoring='accuracy', n_jobs=-1)
    print(f"\n--- ZAMAN SERİSİ CV (5-fold) ---")
    print(f"Fold Skorları : {[f'{s:.4f}' for s in cv_scores]}")
    print(f"Ortalama CV   : {cv_scores.mean():.4f} ± {cv_scores.std():.4f}")

    # ----------------------------------------------------------------
    # Modeli metadata ile birlikte kaydet
    # (gap_predictor.py ve gap_api.py bu formatı okur)
    # ----------------------------------------------------------------
    model_path = os.path.join(os.path.dirname(__file__), "gap_model.pkl")
    model_bundle = {
        'model':         model,
        'features':      available_features,
        'train_size':    len(X_train),
        'test_accuracy': float(accuracy_score(y_test, y_pred)),
    }
    joblib.dump(model_bundle, model_path)
    print(f"\n[*] Model kaydedildi: {model_path}")
    print(f"    Kullanılan özellikler: {available_features}")

    return "Eğitim tamamlandı."

if __name__ == "__main__":
    dataset_path = r"D:\Projects\IdealQuant\gap_training_dataset.csv"
    result = train_gap_model(dataset_path)
    print(f"\nSonuç: {result}")
