# -*- coding: utf-8 -*-
"""
IdealQuant - Export Panel
IdealData export paneli (Veritabanı Entegrasyonlu)
"""

from pathlib import Path
from PySide6.QtWidgets import (
    QWidget, QVBoxLayout, QHBoxLayout, QGroupBox,
    QLabel, QLineEdit, QComboBox, QPushButton,
    QTextEdit, QFileDialog, QMessageBox, QFormLayout
)
from PySide6.QtCore import Signal
from PySide6.QtGui import QFont
from typing import Dict, Any

from src.core.database import db


class ExportPanel(QWidget):
    """IdealData export paneli"""
    
    export_complete = Signal(str)  # process_id
    
    def __init__(self):
        super().__init__()
        self.results = []
        self.selected_params = {}
        self.current_process_id = None
        self.final_params = {}  # {0: S1 params, 1: S2 params}
        self._setup_ui()
    
    def _setup_ui(self):
        """UI bileşenlerini oluştur"""
        layout = QVBoxLayout(self)
        layout.setSpacing(15)
        
        # Süreç seçimi
        process_row = QHBoxLayout()
        process_row.addWidget(QLabel("Süreç:"))
        self.process_combo = QComboBox()
        self.process_combo.setMinimumWidth(250)
        self.process_combo.currentTextChanged.connect(self._on_process_changed)
        process_row.addWidget(self.process_combo)
        
        refresh_btn = QPushButton("↻")
        refresh_btn.setMaximumWidth(30)
        refresh_btn.clicked.connect(self._refresh_processes)
        process_row.addWidget(refresh_btn)
        
        process_row.addStretch()
        layout.addLayout(process_row)
        
        # Üst kısım - Ayarlar
        settings_group = self._create_settings_group()
        layout.addWidget(settings_group)
        
        # Parametre seçimi (DB'den)
        params_group = self._create_params_group()
        layout.addWidget(params_group)
        
        # Önizleme
        preview_group = self._create_preview_group()
        layout.addWidget(preview_group, 1)
        
        # Export butonları
        export_row = QHBoxLayout()
        export_row.addStretch()
        
        preview_btn = QPushButton("👁️ Önizleme")
        preview_btn.clicked.connect(self._generate_preview)
        export_row.addWidget(preview_btn)
        
        export_btn = QPushButton("📤 Export Et")
        export_btn.setObjectName("primaryButton")
        export_btn.clicked.connect(self._export_script)
        export_row.addWidget(export_btn)
        
        layout.addLayout(export_row)
    
    def _create_settings_group(self) -> QGroupBox:
        """Export ayarları grubu"""
        group = QGroupBox("⚙️ Export Ayarları")
        layout = QFormLayout(group)
        
        # Sembol
        self.symbol_edit = QLineEdit("VIP_X030T")
        layout.addRow("Sembol:", self.symbol_edit)
        
        # Periyot
        self.period_combo = QComboBox()
        self.period_combo.addItems(["1", "5", "15", "60", "240"])
        self.period_combo.setCurrentText("15")
        layout.addRow("Periyot (dk):", self.period_combo)
        
        # Vade Tipi
        self.vade_combo = QComboBox()
        self.vade_combo.addItems(["ENDEKS", "SPOT"])
        layout.addRow("Vade Tipi:", self.vade_combo)
        
        # Strateji
        self.strategy_combo = QComboBox()
        self.strategy_combo.addItems([
            "Strateji 1 - Gatekeeper",
            "Strateji 2 - ARS Trend v2",
            "Strateji 3 - Paradise",
            "Strateji 4 - TOMA + Momentum",
            "Strateji 5 - Oliver Kell",
            "Strateji 6 - TOTT HOTT",
            "Birleşik Robot"
        ])
        self.strategy_combo.currentIndexChanged.connect(self._on_strategy_changed_export)
        layout.addRow("Strateji:", self.strategy_combo)
        
        # Çıktı klasörü
        output_row = QHBoxLayout()
        self.output_edit = QLineEdit("d:/Projects/IdealQuant/export")
        output_row.addWidget(self.output_edit)
        browse_btn = QPushButton("...")
        browse_btn.setMaximumWidth(40)
        browse_btn.clicked.connect(self._browse_output)
        output_row.addWidget(browse_btn)
        layout.addRow("Çıktı Klasörü:", output_row)
        
        return group
    
    def _create_params_group(self) -> QGroupBox:
        """Parametre seçimi grubu"""
        group = QGroupBox("📊 Final Parametreler (Valide Edilmiş)")
        layout = QVBoxLayout(group)
        
        self.params_label = QLabel(
            "Henüz valide edilmiş süreç yok.\n\n"
            "Önce Optimizer'da optimizasyon çalıştırın,\n"
            "ardından Validation panelinde final parametreleri seçin."
        )
        self.params_label.setWordWrap(True)
        layout.addWidget(self.params_label)
        
        return group
    
    def _create_preview_group(self) -> QGroupBox:
        """Kod önizleme grubu"""
        group = QGroupBox("📝 Kod Önizleme")
        layout = QVBoxLayout(group)
        
        self.preview_text = QTextEdit()
        self.preview_text.setReadOnly(True)
        self.preview_text.setFont(QFont("Consolas", 10))
        self.preview_text.setPlaceholderText("Önizleme için 'Önizleme' butonuna tıklayın...")
        layout.addWidget(self.preview_text)
        
        return group
    
    def _on_strategy_changed_export(self, index: int):
        """Strateji değiştiğinde vade_combo'yu güncelle (S5 = 3 mod)"""
        self.vade_combo.blockSignals(True)
        prev = self.vade_combo.currentText()
        self.vade_combo.clear()
        if index == 4:  # S5 Oliver Kell
            self.vade_combo.addItems(["VIOP_ENDEKS", "VIOP_SPOT", "SPOT"])
        else:
            self.vade_combo.addItems(["ENDEKS", "SPOT"])
        # Önceki seçimi koru (eşleşirse)
        idx = self.vade_combo.findText(prev)
        if idx >= 0:
            self.vade_combo.setCurrentIndex(idx)
        self.vade_combo.blockSignals(False)
    
    def _browse_output(self):
        """Çıktı klasörü seç"""
        folder = QFileDialog.getExistingDirectory(
            self,
            "Çıktı Klasörü Seç",
            self.output_edit.text()
        )
        if folder:
            self.output_edit.setText(folder)
    
    # =========================================================================
    # SÜREÇ YÖNETİMİ
    # =========================================================================
    
    def _refresh_processes(self):
        """Süreç listesini yenile (sadece valide edilmişler)"""
        self.process_combo.clear()
        processes = db.get_all_processes()
        
        # Sadece validated veya exported süreçleri göster
        valid_processes = [p for p in processes if p['status'] in ('validated', 'exported')]
        
        if not valid_processes:
            self.process_combo.addItem("(Valide edilmiş süreç yok)")
            self.params_label.setText(
                "Henüz valide edilmiş süreç yok.\n\n"
                "Önce Validation panelinde final parametreleri seçin."
            )
            return
        
        for proc in valid_processes:
            display = f"✓ {proc['process_id']}"
            self.process_combo.addItem(display, proc['process_id'])
        
        # İlkini seç
        if valid_processes:
            self.current_process_id = valid_processes[0]['process_id']
            self._load_final_params()
    
    def _on_process_changed(self, text: str):
        """Süreç seçimi değiştiğinde"""
        idx = self.process_combo.currentIndex()
        if idx >= 0:
            self.current_process_id = self.process_combo.itemData(idx)
            self._load_final_params()
    
    def _load_final_params(self):
        """Final parametreleri DB'den yükle"""
        if not self.current_process_id:
            return
        
        # Final parametreleri al
        self.final_params = db.get_final_params(self.current_process_id)
        
        if not self.final_params:
            self.params_label.setText(
                f"⚠️ {self.current_process_id}\n\n"
                "Bu süreç için final parametre seçilmemiş.\n"
                "Validation panelinde en az bir strateji için final seçin."
            )
            return
        
        # Label güncelle
        params_text = f"✓ Süreç: {self.current_process_id}\n\n"
        
        for strategy_idx, params in self.final_params.items():
            strategy_name = {0: "Strateji 1", 1: "Strateji 2", 2: "Strateji 3 (Paradise)", 3: "Strateji 4 (TOMA)", 4: "Strateji 5 (Oliver Kell)", 5: "Strateji 6 (TOTT HOTT)"}.get(strategy_idx, f"Strateji {strategy_idx+1}")
            params_text += f"━━━ {strategy_name} ━━━\n"
            
            # İlk 5 parametre
            count = 0
            for key, value in params.items():
                if count >= 5:
                    params_text += f"  ... ve {len(params) - 5} parametre daha\n"
                    break
                params_text += f"  • {key}: {value}\n"
                count += 1
            
            params_text += "\n"
        
        self.params_label.setText(params_text)
        
        # Symbol ve period'u süreçten al
        proc = db.get_process(self.current_process_id)
        if proc:
            self.symbol_edit.setText(proc['symbol'])
            # Period combo'da ayarla
            period_text = proc['period'].replace('dk', '').replace('G', '240')
            for i in range(self.period_combo.count()):
                if self.period_combo.itemText(i) == period_text:
                    self.period_combo.setCurrentIndex(i)
                    break
            
            # Strateji combo'yu ayarla (DB'deki strategy_index)
            strategy_idx = proc.get('strategy_index', 0)
            if 0 <= strategy_idx <= 5:
                self.strategy_combo.setCurrentIndex(strategy_idx)
            
            # Vade Tipi combo'yu ayarla
            vade = proc.get('vade_tipi', 'ENDEKS')
            vade_idx = self.vade_combo.findText(vade)
            if vade_idx >= 0:
                self.vade_combo.setCurrentIndex(vade_idx)
    
    def _generate_preview(self):
        """Kod önizlemesi oluştur"""
        try:
            from src.export.idealdata_exporter import IdealDataExporter
            
            symbol = self.symbol_edit.text()
            period = int(self.period_combo.currentText())
            vade_tipi = self.vade_combo.currentText()
            strategy_idx = self.strategy_combo.currentIndex()
            
            exporter = IdealDataExporter(symbol, period)
            
            # Final parametreleri kullan
            s1_params = self.final_params.get(0, {})
            s2_params = self.final_params.get(1, {})
            s3_params = self.final_params.get(2, {})
            s4_params = self.final_params.get(3, {})
            s5_params = self.final_params.get(4, {})
            
            if strategy_idx == 0:
                if not s1_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 1 için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy1_code(s1_params, vade_tipi)
            elif strategy_idx == 1:
                if not s2_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 2 için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy2_code(s2_params, vade_tipi)
            elif strategy_idx == 2:
                if not s3_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 3 (Paradise) için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy3_code(s3_params, vade_tipi)
            elif strategy_idx == 3:
                if not s4_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 4 (TOMA) için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy4_code(s4_params, vade_tipi)
            elif strategy_idx == 4:
                if not s5_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 5 (Oliver Kell) için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy5_code(s5_params, vade_tipi)
            elif strategy_idx == 5:
                s6_params = self.final_params.get(5, {})
                if not s6_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 6 (TOTT HOTT) için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy6_code(s6_params, vade_tipi)
            else:
                if not s1_params or not s2_params:
                    QMessageBox.warning(self, "Uyarı", "Birleşik robot için S1 ve S2 final parametreleri gerekli.")
                    return
                code = exporter._generate_robot_code(lot_size=1) # Default 1 lot
            
            self.preview_text.setPlainText(code)
            
        except Exception as e:
            QMessageBox.critical(self, "Hata", f"Önizleme hatası: {str(e)}")
    
    def _export_script(self):
        """Script dosyasını oluştur"""
        try:
            from src.export.idealdata_exporter import IdealDataExporter
            
            symbol = self.symbol_edit.text()
            period = int(self.period_combo.currentText())
            vade_tipi = self.vade_combo.currentText()
            strategy_idx = self.strategy_combo.currentIndex()
            output_dir = Path(self.output_edit.text())
            
            # Klasör yoksa oluştur
            output_dir.mkdir(parents=True, exist_ok=True)
            
            exporter = IdealDataExporter(symbol, period)
            
            # Final parametreleri kullan
            s1_params = self.final_params.get(0, {})
            s2_params = self.final_params.get(1, {})
            
            # Dosya adı
            strategy_names = ["Gatekeeper", "ARS_Trend_v2", "Paradise", "TOMA_Momentum", "Oliver_Kell", "TOTT_HOTT", "Combined"]
            filename = f"{symbol}_{period}DK_{strategy_names[strategy_idx]}.cs"
            filepath = output_dir / filename
            
            # Kod oluştur
            s1_params = self.final_params.get(0, {})
            s2_params = self.final_params.get(1, {})
            s3_params = self.final_params.get(2, {})
            s4_params = self.final_params.get(3, {})
            s5_params = self.final_params.get(4, {})
            
            if strategy_idx == 0:
                if not s1_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 1 için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy1_code(s1_params, vade_tipi)
            elif strategy_idx == 1:
                if not s2_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 2 için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy2_code(s2_params, vade_tipi)
            elif strategy_idx == 2:
                if not s3_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 3 (Paradise) için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy3_code(s3_params, vade_tipi)
            elif strategy_idx == 3:
                if not s4_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 4 (TOMA) için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy4_code(s4_params, vade_tipi)
            elif strategy_idx == 4:
                if not s5_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 5 (Oliver Kell) için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy5_code(s5_params, vade_tipi)
            elif strategy_idx == 5:
                s6_params = self.final_params.get(5, {})
                if not s6_params:
                    QMessageBox.warning(self, "Uyarı", "Strateji 6 (TOTT HOTT) için final parametre bulunamadı.")
                    return
                code = exporter._generate_strategy6_code(s6_params, vade_tipi)
            else:
                if not s1_params or not s2_params:
                    QMessageBox.warning(self, "Uyarı", "Birleşik robot için S1 ve S2 final parametreleri gerekli.")
                    return
                code = exporter._generate_robot_code(lot_size=1)
            
            # Dosyaya yaz
            with open(filepath, 'w', encoding='utf-8') as f:
                f.write(code)
            
            # Süreç durumunu güncelle
            if self.current_process_id:
                db.update_process_status(self.current_process_id, 'exported')
            
            QMessageBox.information(
                self, 
                "Başarılı", 
                f"✅ Script başarıyla oluşturuldu:\n\n{filepath}"
            )
            
            # Signal gönder
            if self.current_process_id:
                self.export_complete.emit(self.current_process_id)
            
        except Exception as e:
            QMessageBox.critical(self, "Hata", f"Export hatası: {str(e)}")
    
    def set_results(self, results: list):
        """Optimizer sonuçlarını al (eski uyumluluk için)"""
        self.results = results
        
        if results:
            # En iyi sonucu seç
            best = results[0]
            self.selected_params = best
    
    def set_process(self, process_id: str):
        """Dışarıdan süreç ayarla"""
        self.current_process_id = process_id
        self._refresh_processes()
        
        # Combo'da ilgili süreci seç
        for i in range(self.process_combo.count()):
            if self.process_combo.itemData(i) == process_id:
                self.process_combo.setCurrentIndex(i)
                break
