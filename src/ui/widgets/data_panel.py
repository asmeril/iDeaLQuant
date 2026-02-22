# -*- coding: utf-8 -*-
"""
IdealQuant - Data Panel
Veri yönetimi paneli (CSV + IdealData Binary)
"""

from pathlib import Path
from PySide6.QtWidgets import (
    QWidget, QVBoxLayout, QHBoxLayout, QGroupBox,
    QPushButton, QLineEdit, QLabel, QFileDialog,
    QTableWidget, QTableWidgetItem, QHeaderView,
    QDateEdit, QSpinBox, QMessageBox, QComboBox,
    QRadioButton, QButtonGroup, QTabWidget
)
from PySide6.QtCore import Signal, Qt, QDate
import pandas as pd

from src.core.database import db


class DataPanel(QWidget):
    """Veri yükleme ve önizleme paneli"""
    
    # Signals
    data_loaded = Signal(object)  # DataFrame gönderir
    process_created = Signal(str)  # process_id gönderir
    
    # IdealData default path
    IDEAL_DATA_PATH = r"D:\\iDeal\\ChartData"
    
    def __init__(self):
        super().__init__()
        self.df = None
        self.current_process_id = None
        self._setup_ui()
        
        # Otomatik yükleme (UI hazir olduktan sonra)
        from PySide6.QtCore import QTimer
        QTimer.singleShot(100, self._try_auto_load_last_session)
    
    def _setup_ui(self):
        """UI bileşenlerini oluştur"""
        layout = QVBoxLayout(self)
        layout.setSpacing(15)
        
        # Veri kaynağı seçimi (Tab)
        self.source_tabs = QTabWidget()
        
        # Tab 1: IdealData Binary
        ideal_tab = self._create_ideal_tab()
        self.source_tabs.addTab(ideal_tab, "IdealData")
        
        # Tab 2: CSV
        csv_tab = self._create_csv_tab()
        csv_tab = self._create_csv_tab()
        self.source_tabs.addTab(csv_tab, "CSV Dosyası")
        
        layout.addWidget(self.source_tabs)
        
        # Filtre grubu
        filter_group = self._create_filter_group()
        layout.addWidget(filter_group)
        
        # Önizleme tablosu (esnek boyutlu olması için stretch veriyoruz, ama altına süreç kutusunu ekleyeceğiz)
        preview_group = self._create_preview_group()
        
        # Süreç Başlatma Grubu (Yeni Tasarım)
        self.process_group = self._create_process_group()
        self.process_group.setEnabled(False) # Veri yüklenene kadar kapalı
        
        # Splitter veya stretch mantığını korumak için
        top_layout = QVBoxLayout()
        top_layout.addWidget(self.source_tabs)
        top_layout.addWidget(filter_group)
        top_layout.addWidget(preview_group, 1)
        
        layout.addLayout(top_layout, 1)
        layout.addWidget(self.process_group)
    
    def _create_process_group(self) -> QGroupBox:
        """Yeni Süreç Başlatma UI Grubu"""
        group = QGroupBox("Merkezi Süreç Başlatma (Strateji Ayarları)")
        group.setStyleSheet("QGroupBox { font-weight: bold; border: 1px solid #c8a2c8; margin-top: 10px; } QGroupBox::title { subcontrol-origin: margin; left: 10px; padding: 0 3px 0 3px; }")
        layout = QHBoxLayout(group)
        
        # Strateji
        layout.addWidget(QLabel("Strateji:"))
        self.strategy_combo = QComboBox()
        self.strategy_combo.addItems([
            "0: ScoreBased (Gatekeeper)", 
            "1: ARS Trend v2", 
            "2: Paradise (Trend+Breakout)", 
            "3: TOMA + Mom"
        ])
        layout.addWidget(self.strategy_combo)
        
        # Vade Tipi
        layout.addWidget(QLabel("Vade Tipi:"))
        self.vade_combo = QComboBox()
        self.vade_combo.addItems(["ENDEKS", "SPOT"])
        layout.addWidget(self.vade_combo)
        
        # Yön Modu
        layout.addWidget(QLabel("Yön Modu:"))
        self.yon_combo = QComboBox()
        self.yon_combo.addItems(["CIFT", "SADECE_AL", "SADECE_SAT"])
        layout.addWidget(self.yon_combo)
        
        layout.addStretch()
        
        self.create_process_btn = QPushButton("▶ Süreci Başlat ve Kilitle")
        self.create_process_btn.setObjectName("primaryButton")
        self.create_process_btn.setStyleSheet("background-color: #4CAF50; color: white; font-weight: bold; padding: 8px 15px;")
        self.create_process_btn.clicked.connect(self._on_create_process_clicked)
        layout.addWidget(self.create_process_btn)
        
        return group
        
    def _on_create_process_clicked(self):
        """Kullanıcı butona bastığında süreci oluştur ve sinyal gönder"""
        if self.df is None or len(self.df) == 0:
            QMessageBox.warning(self, "Hata", "Önce veri yüklemelisiniz!")
            return
            
        # UI'dan değerleri al
        strategy_index = self.strategy_combo.currentIndex()
        vade_tipi = self.vade_combo.currentText()
        yon_modu = self.yon_combo.currentText()
        
        # Hangi kaynaktan yüklendiğini bul
        current_tab = self.source_tabs.currentIndex()
        if current_tab == 0:
            # IdealData
            chart_data = self.ideal_path_edit.text()
            market = self.market_combo.currentText()
            symbol = self.symbol_combo.currentText()
            period = self.period_combo.currentText()
            
            from src.data.ideal_parser import get_file_path, PERIOD_MAP
            found_path = get_file_path(chart_data, market, symbol, period)
            if found_path:
                data_file_path = found_path
            else:
                period_info = PERIOD_MAP.get(period, {'folder': period, 'ext': f'.{period}'})
                data_file_path = Path(chart_data) / market / period_info['folder'] / f"{symbol}{period_info['ext']}"
                
            full_symbol = f"{market}_{symbol}"
            per_str = f"{period}dk" if period.isdigit() else period
            
        else:
            # CSV
            csv_path = self.csv_path_edit.text().strip()
            fname = Path(csv_path).stem
            parts = fname.split('_')
            full_symbol = parts[0] if parts else 'UNKNOWN'
            per_str = parts[1] if len(parts) > 1 else '1dk'
            data_file_path = str(Path(csv_path).resolve())
            
        # Veritabanında süreci oluştur
        process_id = db.create_process(
            symbol=full_symbol,
            period=per_str,
            data_file=str(data_file_path),
            data_rows=len(self.df),
            strategy_index=strategy_index,
            vade_tipi=vade_tipi,
            yon_modu=yon_modu
        )
        self.current_process_id = process_id
        
        # Diğer panellere sinyalleri fırlat
        self.data_loaded.emit(self.df)
        self.process_created.emit(process_id)
        
        QMessageBox.information(
            self, 
            "Süreç Oluşturuldu", 
            f"Süreç ID: {process_id}\n\nStrateji: {strategy_index}\nVade: {vade_tipi}\nYön: {yon_modu}\n\nAyarlar kilitlendi. Optimizasyon sekmesine geçebilirsiniz."
        )
    
    def _create_ideal_tab(self) -> QWidget:
        """IdealData veri kaynağı tab'ı"""
        widget = QWidget()
        layout = QVBoxLayout(widget)
        
        # ChartData Path
        path_row = QHBoxLayout()
        path_row.addWidget(QLabel("ChartData Yolu:"))
        self.ideal_path_edit = QLineEdit(self.IDEAL_DATA_PATH)
        path_row.addWidget(self.ideal_path_edit, 1)
        browse_btn = QPushButton("...")
        browse_btn.setMaximumWidth(40)
        browse_btn.clicked.connect(self._browse_ideal_path)
        path_row.addWidget(browse_btn)
        layout.addLayout(path_row)
        
        # Seçiciler
        select_row = QHBoxLayout()
        
        # Pazar
        select_row.addWidget(QLabel("Pazar:"))
        self.market_combo = QComboBox()
        self.market_combo.addItems(['VIP', 'IMKBH', 'IMKBX', 'FX', 'DOVIZ'])
        self.market_combo.currentTextChanged.connect(self._on_market_changed)
        select_row.addWidget(self.market_combo)
        
        # Periyot
        select_row.addWidget(QLabel("Periyot:"))
        self.period_combo = QComboBox()
        self.period_combo.addItems(['1', '5', '15', '60', 'G'])
        self.period_combo.currentTextChanged.connect(self._on_period_changed)
        select_row.addWidget(self.period_combo)
        
        # Sembol
        select_row.addWidget(QLabel("Sembol:"))
        self.symbol_combo = QComboBox()
        self.symbol_combo.setEditable(True)
        self.symbol_combo.setMinimumWidth(150)
        select_row.addWidget(self.symbol_combo)
        
        select_row.addStretch()
        
        # Sembolleri yükle butonu
        refresh_btn = QPushButton("Yenile")
        refresh_btn.clicked.connect(self._refresh_symbols)
        select_row.addWidget(refresh_btn)
        
        layout.addLayout(select_row)
        
        # Yükle ve DB Butonları
        btn_row = QHBoxLayout()
        
        db_btn = QPushButton("🛠️ Veritabanı Yönetimi")
        db_btn.clicked.connect(self.show_db_manager)
        btn_row.addWidget(db_btn)
        
        btn_row.addStretch()
        load_btn = QPushButton("IdealData'dan Yükle")
        load_btn.setObjectName("primaryButton")
        load_btn.clicked.connect(self._load_ideal_data)
        btn_row.addWidget(load_btn)
        layout.addLayout(btn_row)
        
        # İlk yükleme
        self._refresh_symbols()
        
        return widget
    
    def _create_csv_tab(self) -> QWidget:
        """CSV veri kaynağı tab'ı"""
        widget = QWidget()
        layout = QVBoxLayout(widget)
        
        # CSV dosya seçimi
        csv_row = QHBoxLayout()
        csv_row.addWidget(QLabel("CSV Dosyası:"))
        self.csv_path_edit = QLineEdit()
        self.csv_path_edit.setPlaceholderText("VIP_X030T_1dk_.csv gibi...")
        csv_row.addWidget(self.csv_path_edit, 1)
        browse_btn = QPushButton("Gözat...")
        browse_btn.clicked.connect(self._browse_csv)
        csv_row.addWidget(browse_btn)
        layout.addLayout(csv_row)
        
        # Yükle butonu
        btn_row = QHBoxLayout()
        btn_row.addStretch()
        load_btn = QPushButton("CSV'den Yükle")
        load_btn.setObjectName("primaryButton")
        load_btn.clicked.connect(self._load_csv_data)
        btn_row.addWidget(load_btn)
        layout.addLayout(btn_row)
        
        layout.addStretch()
        
        return widget
    
    def _create_filter_group(self) -> QGroupBox:
        """Filtre grubu"""
        group = QGroupBox("Filtreler")
        layout = QHBoxLayout(group)
        
        # Tarih aralığı
        layout.addWidget(QLabel("Başlangıç:"))
        self.start_date = QDateEdit()
        self.start_date.setCalendarPopup(True)
        self.start_date.setDate(QDate(2024, 1, 1))
        layout.addWidget(self.start_date)
        
        layout.addWidget(QLabel("Bitiş:"))
        self.end_date = QDateEdit()
        self.end_date.setCalendarPopup(True)
        self.end_date.setDate(QDate.currentDate())
        layout.addWidget(self.end_date)
        
        layout.addSpacing(20)
        
        # Son N satır
        layout.addWidget(QLabel("Son N satır:"))
        self.last_n_rows = QSpinBox()
        self.last_n_rows.setRange(0, 1000000)
        self.last_n_rows.setValue(0)
        self.last_n_rows.setSpecialValueText("Tümü")
        layout.addWidget(self.last_n_rows)
        
        layout.addStretch()
        
        # Filtrele butonu
        filter_btn = QPushButton("Filtrele")
        filter_btn.clicked.connect(self._apply_filter)
        layout.addWidget(filter_btn)
        
        return group
    
    def _create_preview_group(self) -> QGroupBox:
        """Önizleme tablosu grubu"""
        group = QGroupBox("Veri Önizleme")
        layout = QVBoxLayout(group)
        
        # İstatistikler
        stats_row = QHBoxLayout()
        self.stats_label = QLabel("Veri yüklenmedi")
        stats_row.addWidget(self.stats_label)
        stats_row.addStretch()
        layout.addLayout(stats_row)
        
        # Tablo
        self.preview_table = QTableWidget()
        self.preview_table.setAlternatingRowColors(True)
        self.preview_table.horizontalHeader().setSectionResizeMode(QHeaderView.Stretch)
        layout.addWidget(self.preview_table)
        
        return group
    
    def _browse_ideal_path(self):
        """IdealData klasörü seç"""
        folder = QFileDialog.getExistingDirectory(
            self,
            "ChartData Klasörü Seç",
            self.ideal_path_edit.text()
        )
        if folder:
            self.ideal_path_edit.setText(folder)
            self._refresh_symbols()
    
    def _browse_csv(self):
        """CSV dosyası seç"""
        file_path, _ = QFileDialog.getOpenFileName(
            self,
            "CSV Dosyası Seç",
            str(Path.home()),
            "CSV Dosyaları (*.csv);;Tüm Dosyalar (*)"
        )
        if file_path:
            self.csv_path_edit.setText(file_path)
    
    def _on_market_changed(self, market: str):
        """Pazar değiştiğinde"""
        self._refresh_symbols()
    
    def _on_period_changed(self, period: str):
        """Periyot değiştiğinde"""
        self._refresh_symbols()
    
    def _refresh_symbols(self):
        """Sembolleri yenile"""
        try:
            from src.data.ideal_parser import list_symbols
            
            chart_data = self.ideal_path_edit.text()
            market = self.market_combo.currentText()
            period = self.period_combo.currentText()
            
            symbols = list_symbols(chart_data, market, period)
            
            self.symbol_combo.clear()
            self.symbol_combo.addItems(symbols)
            
            # Varsayılan olarak X030-T seç (vadeli, akşam seansı dahil)
            if 'X030-T' in symbols:
                self.symbol_combo.setCurrentText('X030-T')
            elif 'X030' in symbols:
                self.symbol_combo.setCurrentText('X030')
            
        except Exception as e:
            print(f"Sembol yükleme hatası: {e}")
    
    def _load_ideal_data(self):
        """IdealData'dan veri yükle"""
        try:
            from src.data.ideal_parser import load_ideal_data
            
            chart_data = self.ideal_path_edit.text()
            market = self.market_combo.currentText()
            symbol = self.symbol_combo.currentText()
            period = self.period_combo.currentText()
            
            if not symbol:
                QMessageBox.warning(self, "Uyarı", "Lütfen bir sembol seçin.")
                return
            
            df = load_ideal_data(chart_data, market, symbol, period)
            
            if df is None or len(df) == 0:
                QMessageBox.warning(self, "Uyarı", f"{symbol} için veri bulunamadı.")
                return
            
            # Kolon isimlerini standartlaştır (eğer zaten aliaslar yoksa)
            rename_map = {}
            standard_cols = {
                'Open': 'Acilis',
                'High': 'Yuksek',
                'Low': 'Dusuk',
                'Close': 'Kapanis',
                'Volume': 'Lot',
                'Amount': 'Hacim'
            }
            for old_col, new_col in standard_cols.items():
                if old_col in df.columns and new_col not in df.columns:
                    rename_map[old_col] = new_col
            
            if rename_map:
                df = df.rename(columns=rename_map)
            
            self.df = df
            self.df_raw = df.copy()  # Filtre için ham veriyi sakla
            self._update_preview()
            
            # Veri yüklendi, Süreç başlatma kutusunu aktif et
            self.process_group.setEnabled(True)
            self.stats_label.setText(self.stats_label.text() + " - Yüklendi, Süreç Başlatılması Bekleniyor...")
            
        except Exception as e:
            QMessageBox.critical(self, "Hata", f"Veri yüklenirken hata: {str(e)}")
    
    def _load_csv_data(self):
        """CSV'den veri yükle"""
        csv_path = self.csv_path_edit.text().strip()
        
        if not csv_path:
            QMessageBox.warning(self, "Uyarı", "Lütfen bir CSV dosyası seçin.")
            return
        
        if not Path(csv_path).exists():
            QMessageBox.warning(self, "Hata", f"Dosya bulunamadı: {csv_path}")
            return
        
        try:
            # CSV yükle
            df = pd.read_csv(
                csv_path, 
                sep=';', 
                decimal=',', 
                encoding='cp1254',
                header=0,
                low_memory=False
            )
            df.columns = ['Tarih', 'Saat', 'Acilis', 'Yuksek', 'Dusuk', 'Kapanis', 'Ortalama', 'Hacim', 'Lot']
            
            # Sayısal dönüşüm
            for c in ['Acilis', 'Yuksek', 'Dusuk', 'Kapanis', 'Hacim', 'Lot']:
                df[c] = pd.to_numeric(df[c], errors='coerce')
            
            df['Tipik'] = (df['Yuksek'] + df['Dusuk'] + df['Kapanis']) / 3
            df.dropna(inplace=True)
            
            # DateTime oluştur
            df['DateTime'] = pd.to_datetime(
                df['Tarih'] + ' ' + df['Saat'], 
                format='%d.%m.%Y %H:%M:%S', 
                errors='coerce'
            )
            df = df.dropna(subset=['DateTime']).reset_index(drop=True)
            
            self.df = df
            self.df_raw = df.copy()  # Filtre için ham veriyi sakla
            self._update_preview()
            
            # Veri yüklendi, Süreç başlatma kutusunu aktif et
            self.process_group.setEnabled(True)
            self.stats_label.setText(self.stats_label.text() + " - Yüklendi, Süreç Başlatılması Bekleniyor...")
            
        except Exception as e:
            QMessageBox.critical(self, "Hata", f"Veri yüklenirken hata: {str(e)}")
    
    def _apply_filter(self):
        """Filtreleri uygula - Hem önizleme hem de gerçek veriyi güncelle"""
        # Ham veri yoksa çık
        if not hasattr(self, 'df_raw') or self.df_raw is None:
            if self.df is not None:
                self.df_raw = self.df.copy()  # İlk kez: mevcut veriyi raw olarak kaydet
            else:
                return
        
        # Tarih filtresi
        start = self.start_date.date().toPython()
        end = self.end_date.date().toPython()
        
        filtered = self.df_raw[
            (self.df_raw['DateTime'].dt.date >= start) & 
            (self.df_raw['DateTime'].dt.date <= end)
        ].copy()
        
        # Son N satır
        n = self.last_n_rows.value()
        if n > 0:
            filtered = filtered.tail(n)
        
        # Veriyi güncelle ve diğer panellere bildir
        self.df = filtered.reset_index(drop=True)
        self._update_preview()
        
        # Optimizasyon ve Validasyon panellerine sinyal gönder
        self.data_loaded.emit(self.df)
        
        # Kullanıcıya bilgi ver
        from PySide6.QtWidgets import QMessageBox
        QMessageBox.information(
            self, 
            "Filtre Uygulandı", 
            f"Filtrelenmiş veri: {len(self.df):,} bar\n"
            f"Tarih aralığı: {start} - {end}"
        )

    
    def _update_preview(self, df=None):
        """Önizleme tablosunu güncelle"""
        if df is None:
            df = self.df
        
        if df is None:
            return
        
        # İstatistikler
        self.stats_label.setText(
            f"Toplam: {len(df):,} bar | "
            f"{df['DateTime'].min().strftime('%Y-%m-%d')} -> {df['DateTime'].max().strftime('%Y-%m-%d')}"
        )
        
        # Tablo (son 100 satır)
        preview_df = df.tail(100)
        cols = ['DateTime', 'Acilis', 'Yuksek', 'Dusuk', 'Kapanis', 'Lot']
        
        # Mevcut kolonları kullan
        available_cols = [c for c in cols if c in preview_df.columns]
        
        self.preview_table.setRowCount(len(preview_df))
        self.preview_table.setColumnCount(len(available_cols))
        self.preview_table.setHorizontalHeaderLabels(available_cols)
        
        for row_idx, (_, row) in enumerate(preview_df.iterrows()):
            for col_idx, col in enumerate(available_cols):
                value = row[col]
                if col == 'DateTime':
                    text = str(value)[:19]
                elif isinstance(value, float):
                    text = f"{value:.2f}"
                else:
                    text = str(value)
                self.preview_table.setItem(row_idx, col_idx, QTableWidgetItem(text))
    
    def get_data(self) -> pd.DataFrame:
        """Yüklü veriyi döndür"""
        return self.df

    def show_db_manager(self):
        """Veritabanı yöneticisini göster"""
        from src.ui.widgets.database_manager import DatabaseManager
        dialog = DatabaseManager(self)
        dialog.exec()


    def _try_auto_load_last_session(self):
        """Son oturumu otomatik yükle"""
        try:
            processes = db.get_all_processes()
            if not processes:
                return
            
            last_process = processes[0]
            data_file = last_process.get('data_file', '')
            
            if not data_file or not Path(data_file).exists():
                return
                
            print(f"[AUTO-LOAD] Last session found: {last_process['symbol']} ({last_process['process_id']})")
            
            # Veri tipini belirle
            is_csv = str(data_file).lower().endswith('.csv')
            
            if is_csv:
                # CSV Yükle
                self.source_tabs.setCurrentIndex(1)
                self.csv_path_edit.setText(data_file)
                self._load_csv_data()
            else:
                # IdealData Yükle
                self.source_tabs.setCurrentIndex(0)
                
                # Sembol ve Periyot ayristir
                # Symbol format: VIP_X030 or similar
                # Period format: 1dk or 1
                
                full_symbol = last_process['symbol']
                period_str = last_process['period'].replace('dk', '') # '1dk' -> '1'
                
                if '_' in full_symbol:
                    parts = full_symbol.split('_', 1)
                    market = parts[0]
                    symbol = parts[1]
                else:
                    market = "VIP" # Fallback
                    symbol = full_symbol
                
                # UI Set
                self.market_combo.setCurrentText(market)
                self.period_combo.setCurrentText(period_str)
                
                # Sembolleri yenile ki symbol_combo dolsun
                self._refresh_symbols()
                
                # Sembolu sec
                index = self.symbol_combo.findText(symbol)
                if index >= 0:
                    self.symbol_combo.setCurrentIndex(index)
                else:
                    self.symbol_combo.setCurrentText(symbol)

                # Yükle
                self._load_ideal_data()
                
        except Exception as e:
            print(f"[AUTO-LOAD] Failed: {e}")
            import traceback
            traceback.print_exc()
