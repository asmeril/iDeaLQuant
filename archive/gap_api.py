from flask import Flask, request, jsonify
import joblib
import pandas as pd
import os

app = Flask(__name__)

MODEL_PATH = os.path.join(os.path.dirname(__file__), "gap_model.pkl")

# Uygulama başladığında model bir kez yüklenir, her istekte yeniden açılmaz
_model_cache: dict = {}

def get_model():
    """Model ve özellik listesini döndürür. İlk çağrıda yükler, sonraki çağrılarda cache'ten okur."""
    if 'model' not in _model_cache:
        if not os.path.exists(MODEL_PATH):
            return None, None
        raw = joblib.load(MODEL_PATH)
        if isinstance(raw, dict):
            # Yeni format: gap_trainer.py metadata ile kaydetti
            _model_cache['model']    = raw['model']
            _model_cache['features'] = raw['features']
        else:
            # Eski format uyumluluğu
            _model_cache['model']    = raw
            _model_cache['features'] = ['Gap_Yuzde', 'Volatility_Std', 'Volume_Change']
    return _model_cache['model'], _model_cache['features']


@app.route('/predict', methods=['POST'])
def predict():
    model, features = get_model()
    if model is None:
        return jsonify({'error': 'Model bulunamadı. Önce gap_trainer.py çalıştırın.'}), 500

    try:
        data = request.get_json(force=True)
        if isinstance(data, dict):
            data_list = [data]
        elif isinstance(data, list):
            data_list = data
        else:
            return jsonify({'error': 'Geçersiz istek formatı (dict veya list bekleniyor)'}), 400

        predictions = []
        for item in data_list:
            # Hem kısa takma adları (gap_yuzde) hem de tam adları (Gap_Yuzde) kabul et
            feature_map = {
                'Gap_Yuzde':      float(item.get('gap_yuzde',      item.get('Gap_Yuzde',      0.0))),
                'Gap_Yon_Binary': int(item.get('gap_yon_binary',   item.get('Gap_Yon_Binary',
                                      1 if item.get('gap_yon', 'Yukari') == 'Yukari' else 0))),
                'Volatility_Std': float(item.get('vol_std',        item.get('Volatility_Std', 0.0))),
                'Volume_Change':  float(item.get('vol_change',     item.get('Volume_Change',  0.0))),
                'Gun_Sira':       int(item.get('gun_sira',         item.get('Gun_Sira',       0))),
                'Pre_Trend_5Gun': float(item.get('pre_trend',      item.get('Pre_Trend_5Gun', 0.0))),
                'Gap_Kategori':   int(item.get('gap_kategori',     item.get('Gap_Kategori',   1))),
                'Ilk5Bar_Yonu':   int(item.get('ilk5_yonu',        item.get('Ilk5Bar_Yonu',   0))),
            }

            # Modelin beklediği özellikleri al
            df_input = pd.DataFrame([{f: feature_map[f] for f in features if f in feature_map}])

            pred = int(model.predict(df_input)[0])
            prob = model.predict_proba(df_input)[0]

            predictions.append({
                'decision':     'TREND_DEVAM' if pred == 1 else 'GAP_KAPANIYOR',
                'prob_trend':   round(float(prob[1]), 4),
                'prob_reversal': round(float(prob[0]), 4),
            })

        if len(predictions) == 1:
            return jsonify(predictions[0])
        return jsonify({'batch_results': predictions})

    except Exception as e:
        return jsonify({'error': str(e)}), 400


@app.route('/status', methods=['GET'])
def status():
    """Model durumunu ve kullanılan özellikleri döndürür."""
    model, features = get_model()
    if model is None:
        return jsonify({'status': 'model_missing', 'message': 'Model yüklenmedi'}), 503
    return jsonify({
        'status':   'ok',
        'features': features,
        'model':    type(model).__name__,
    })


if __name__ == '__main__':
    model, features = get_model()
    if model is None:
        print("[!] UYARI: Model bulunamadı. Önce gap_trainer.py çalıştırın.")
    else:
        print(f"[*] Model yüklendi ({type(model).__name__}). Özellikler: {features}")
    print("[*] Gap Prediction API başlatılıyor... http://0.0.0.0:5000")
    app.run(host='0.0.0.0', port=5000, debug=False)
