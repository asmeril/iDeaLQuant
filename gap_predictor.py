import pandas as pd
import joblib
import os

MODEL_PATH = os.path.join(os.path.dirname(__file__), "gap_model.pkl")

def load_model(model_path=MODEL_PATH):
    """
    Model dosyasını yükler.
    Yeni format: {'model': ..., 'features': [...], ...}
    Eski format: doğrudan sklearn model objesi
    """
    raw = joblib.load(model_path)
    if isinstance(raw, dict):
        return raw['model'], raw['features']
    # Eski format uyumluluğu
    return raw, ['Gap_Yuzde', 'Volatility_Std', 'Volume_Change']


def predict_gap(input_data: dict, model_path=MODEL_PATH) -> dict:
    """
    Eğitilmiş modeli kullanarak yeni bir gap için tahmin yapar.

    Parametreler (tam özellik seti):
      gap_yuzde        : float  — Gap büyüklüğü (%)
      gap_yon_binary   : int    — 1=Yukari, 0=Asagi
      vol_std          : float  — Gap öncesi volatilite (Kapanış std, 20 bar)
      vol_change       : float  — Hacim değişimi (oran)
      gun_sira         : int    — Haftanın günü (0=Pzt … 4=Cuma)
      pre_trend        : float  — Son 5 gün kapanış trendi (%)
      gap_kategori     : int    — 0=Küçük, 1=Orta, 2=Büyük
      ilk5_yonu        : int    — İlk 5 barın yönü (+1 / -1 / 0)

    Model sadece eğitimde gördüğü özellikleri kullanır (features listesi).
    """
    if not os.path.exists(model_path):
        return {'error': f'Model dosyası bulunamadı: {model_path}'}

    try:
        model, features = load_model(model_path)
    except Exception as e:
        return {'error': f'Model yükleme hatası: {e}'}

    # API girdi adları → model özellik adları eşlemesi
    alias_map = {
        'Gap_Yuzde':      input_data.get('gap_yuzde',      input_data.get('Gap_Yuzde',      0.0)),
        'Gap_Yon_Binary': input_data.get('gap_yon_binary', input_data.get('Gap_Yon_Binary', 1)),
        'Volatility_Std': input_data.get('vol_std',        input_data.get('Volatility_Std', 0.0)),
        'Volume_Change':  input_data.get('vol_change',     input_data.get('Volume_Change',  0.0)),
        'Gun_Sira':       input_data.get('gun_sira',       input_data.get('Gun_Sira',       0)),
        'Pre_Trend_5Gun': input_data.get('pre_trend',      input_data.get('Pre_Trend_5Gun', 0.0)),
        'Gap_Kategori':   input_data.get('gap_kategori',   input_data.get('Gap_Kategori',   1)),
        'Ilk5Bar_Yonu':   input_data.get('ilk5_yonu',      input_data.get('Ilk5Bar_Yonu',   0)),
    }

    try:
        df_input = pd.DataFrame([{f: alias_map[f] for f in features}])
    except KeyError as e:
        return {'error': f'Eksik özellik: {e}. Gerekli: {features}'}

    prediction  = int(model.predict(df_input)[0])
    probability = model.predict_proba(df_input)[0]

    karar = "TREND DEVAM (AL)" if prediction == 1 else "GAP KAPANIYOR (SAT/BEKLE)"

    return {
        'karar':        karar,
        'label':        prediction,
        'prob_devam':   round(float(probability[1]), 4),
        'prob_kapanma': round(float(probability[0]), 4),
        'ozellikler':   features,
    }


if __name__ == "__main__":
    # Örnek tahmin — gün içi kapanma modeli için temsili değerler
    sample = {
        'gap_yuzde':      0.25,   # %0.25 yukarı gap
        'gap_yon_binary': 1,      # Yukari
        'vol_std':        5.0,    # Orta volatilite
        'vol_change':     0.15,   # %15 hacim artışı
        'gun_sira':       0,      # Pazartesi
        'pre_trend':      1.2,    # Son 5 günde %1.2 artış
        'gap_kategori':   1,      # Orta büyüklük
        'ilk5_yonu':      1,      # İlk 5 bar yukarı
    }

    print(f"[*] Model yükleniyor: {MODEL_PATH}")
    result = predict_gap(sample)

    if 'error' in result:
        print(f"Hata: {result['error']}")
    else:
        print("\n--- TAHMİN SONUCU ---")
        print(f"Karar          : {result['karar']}")
        print(f"Trend Devam    : {result['prob_devam']:.2%}")
        print(f"Gap Kapanıyor  : {result['prob_kapanma']:.2%}")
        print(f"Özellikler     : {result['ozellikler']}")
