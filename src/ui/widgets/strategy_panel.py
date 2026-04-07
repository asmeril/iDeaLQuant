# -*- coding: utf-8 -*-
"""
IdealQuant - Strategy Panel
Strateji seçimi ve parametre düzenleme
"""

from PySide6.QtWidgets import (
    QWidget, QVBoxLayout, QHBoxLayout, QGroupBox,
    QLabel, QComboBox, QSpinBox, QDoubleSpinBox,
    QPushButton, QScrollArea, QFormLayout, QMessageBox
)
from PySide6.QtCore import Signal
import json
from pathlib import Path


class StrategyPanel(QWidget):
    """Strateji seçimi ve parametre düzenleme paneli"""
    
    # Signals
    config_changed = Signal(dict)  # Strateji config gönderir
    
    # Varsayılan parametreler
    STRATEGY1_DEFAULTS = {
        'min_score': 3,
        'exit_score': 3,
        'ars_period': 3,
        'ars_k': 0.01,
        'adx_period': 17,
        'adx_threshold': 25.0,
        'macdv_short': 13,
        'macdv_long': 28,
        'macdv_signal': 8,
        'netlot_threshold': 20.0,
        'yatay_ars_bars': 10,
        'ars_mesafe_threshold': 0.25,
        'bb_period': 20,
        'bb_std': 2.0,
        'bb_width_multiplier': 0.8,
        'bb_avg_period': 50,
        'filter_score_threshold': 2,
    }
    
    STRATEGY2_DEFAULTS = {
        'ars_ema_period': 3,
        'ars_atr_period': 10,
        'ars_atr_mult': 0.5,
        'ars_min_band': 0.002,
        'ars_max_band': 0.015,
        'momentum_period': 5,
        'breakout_period': 10,
        'mfi_period': 14,
        'mfi_hhv_period': 14,
        'volume_hhv_period': 14,
        'atr_exit_period': 14,
        'atr_sl_mult': 2.0,
        'atr_tp_mult': 5.0,
        'atr_trail_mult': 2.0,
        'exit_confirm_bars': 2,
        'exit_confirm_mult': 1.0,
    }
    
    STRATEGY3_DEFAULTS = {
        'ema_period': 21,
        'dsma_period': 50,
        'ma_period': 20,
        'hh_period': 25,
        'vol_hhv_period': 14,
        'mom_period': 60,
        'mom_alt': 98.0,
        'mom_ust': 102.0,
        'atr_period': 14,
        'atr_sl': 2.0,
        'atr_tp': 4.0,
        'atr_trail': 2.5,
    }
    
    STRATEGY4_DEFAULTS = {
        'toma_period': 2,
        'toma_opt': 2.1,
        'mom_period': 500,
        'mom_limit_low': 98.5,
        'mom_limit_high': 101.5,
        'trix_period': 50,
        'trix_period2': 40,  # TRIX2 for Layer 2 (MOM < low)
        'trix_lb1': 50,
        'trix_lb2': 60,
        'hhv1_period': 20, 'llv1_period': 20,
        'hhv2_period': 40, 'llv2_period': 40,
        'hhv3_period': 40, 'llv3_period': 40,
        'kar_al': 0.0,
        'iz_stop': 0.0
    }
    
    STRATEGY5_DEFAULTS = {
        'ema_fast': 10,
        'ema_slow': 20,
        'breakout_period': 10,
        'adx_period': 14,
        'adx_threshold': 20.0,
        'vol_ma_period': 20,
        'trailing_stop_pct': 1.5,
    }
    
    STRATEGY6_DEFAULTS = {
        'ott_period': 30,
        'ott_pct_big': 7.5,
        'ott_pct_small': 3.4,
        'ott_mult': 0.0008,
        'sott_pct': 0.3,
        'gate_period': 22,
        'gate_pct': 0.5,
    }
    
    STRATEGY8_DEFAULTS = {
        'min_gap_pct': 0.05,
        'max_gap_pct': 2.00,
        'cuma_aktif': False,
        'or_bars': 15,
        'rsi_filtre_aktif': True,
        'rsi_period': 5,
        'rsi_ob': 62.0,
        'rsi_os': 38.0,
        'hacim_filtre_aktif': True,
        'hacim_ma_period': 20,
        'hacim_oran': 0.8,
        'atr_period': 14,
        'atr_stop_mult': 0.5,
        'gap_window_bars': 210,
        'cooldown_bars': 3,
    }

    STRATEGY7_DEFAULTS = {
        # Layer 1
        'ars_k': 1.23,
        'atr_stop_mult_long': 1.5,
        'atr_stop_mult_short': 1.5,
        'kar_al_yuzde_long': 2.0,
        'kar_al_yuzde_short': 2.0,
        'hhv_period': 12,
        'llv_period': 12,
        'vol_ratio': 0.8,
        # Layer 2
        'st_factor': 3.0,
        'ema_fast_period': 9,
        'ema_slow_period': 21,
        'mfi_hhv_period': 5,
        'mfi_llv_period': 5,
        # Layer 3
        'toma_period2': 2.1,
        'mfi_period': 14,
        'mfi_long': 55.0,
        'mfi_short': 45.0,
        # Layer 4-5
        'min_hold_bars': 2,
        'max_hold_bars': 20,
        'cooldown_bars': 2,
    }
    
    def __init__(self):
        super().__init__()
        self.df = None
        self.param_widgets = {}
        self._setup_ui()
    
    def _setup_ui(self):
        """UI bileşenlerini oluştur"""
        layout = QVBoxLayout(self)
        layout.setSpacing(15)
        
        # Strateji seçimi
        select_group = self._create_strategy_select()
        layout.addWidget(select_group)
        
        # Parametre düzenleme (scrollable)
        scroll = QScrollArea()
        scroll.setWidgetResizable(True)
        self.params_container = QWidget()
        self.params_layout = QVBoxLayout(self.params_container)
        scroll.setWidget(self.params_container)
        layout.addWidget(scroll, 1)
        
        # Alt butonlar
        btn_row = QHBoxLayout()
        
        reset_btn = QPushButton("Varsayilana Don")
        reset_btn.clicked.connect(self._reset_to_defaults)
        btn_row.addWidget(reset_btn)
        
        load_btn = QPushButton("Preset Yukle")
        load_btn.clicked.connect(self._load_preset)
        btn_row.addWidget(load_btn)
        
        save_btn = QPushButton("Preset Kaydet")
        save_btn.clicked.connect(self._save_preset)
        btn_row.addWidget(save_btn)
        
        btn_row.addStretch()
        
        apply_btn = QPushButton("Uygula")
        apply_btn.setObjectName("primaryButton")
        apply_btn.clicked.connect(self._apply_config)
        btn_row.addWidget(apply_btn)
        
        layout.addLayout(btn_row)
        
        # Manuel Backtest bölümü
        backtest_group = QGroupBox("Manuel Backtest")
        backtest_layout = QVBoxLayout(backtest_group)
        
        # Backtest butonu
        backtest_btn_row = QHBoxLayout()
        self.backtest_btn = QPushButton("Backtest Calistir")
        self.backtest_btn.clicked.connect(self._run_manual_backtest)
        backtest_btn_row.addWidget(self.backtest_btn)
        backtest_btn_row.addStretch()
        backtest_layout.addLayout(backtest_btn_row)
        
        # Sonuç etiketi
        self.backtest_result_label = QLabel("Veri yukleyip parametreleri ayarladiktan sonra backtest calistirin.")
        self.backtest_result_label.setWordWrap(True)
        self.backtest_result_label.setStyleSheet("padding: 10px; background-color: #1e1e2e; border-radius: 5px;")
        backtest_layout.addWidget(self.backtest_result_label)
        
        layout.addWidget(backtest_group)
        
        # Varsayılan stratejiyi yükle
        self._on_strategy_changed(0)
    
    def _create_strategy_select(self) -> QGroupBox:
        """Strateji seçimi grubu"""
        group = QGroupBox("🎯 Strateji Seçimi")
        layout = QHBoxLayout(group)
        
        layout.addWidget(QLabel("Strateji:"))
        self.strategy_combo = QComboBox()
        self.strategy_combo.addItems([
            "Strateji 1 - Score-Based Gatekeeper",
            "Strateji 2 - ARS Trend Takip v2",
            "Strateji 3 - Paradise",
            "Strateji 4 - TOMA + Momentum",
            "Strateji 5 - Oliver Kell",
            "Strateji 6 - TOTT HOTT",
            "Strateji 7 - DeepScalp v1.2",
            "Strateji 8 - Gap Reversal v1.0"
        ])
        self.strategy_combo.currentIndexChanged.connect(self._on_strategy_changed)
        layout.addWidget(self.strategy_combo, 1)
        
        layout.addWidget(QLabel("Vade Tipi:"))
        self.vade_combo = QComboBox()
        self.vade_combo.addItems(["ENDEKS", "SPOT"])
        layout.addWidget(self.vade_combo)
        
        return group
    
    def _on_strategy_changed(self, index: int):
        """Strateji değiştiğinde parametreleri güncelle"""
        # Mevcut widget'ları temizle
        for widget in self.param_widgets.values():
            widget.setParent(None)
        self.param_widgets.clear()
        
        # Layout'taki widget'ları temizle
        while self.params_layout.count():
            item = self.params_layout.takeAt(0)
            if item.widget():
                item.widget().deleteLater()
        
        # Yeni parametreleri oluştur
        if index == 0:
            self._create_strategy1_params()
        elif index == 1:
            self._create_strategy2_params()
        elif index == 2:
            self._create_strategy3_params()
        elif index == 3:
            self._create_strategy4_params()
        elif index == 4:
            self._create_strategy5_params()
        elif index == 5:
            self._create_strategy6_params()
        elif index == 6:
            self._create_strategy7_params()
        elif index == 7:
            self._create_strategy8_params()
    
    def _create_strategy1_params(self):
        """Strateji 1 parametrelerini oluştur"""
        defaults = self.STRATEGY1_DEFAULTS
        
        # Skor Ayarları
        score_group = QGroupBox("📊 Skor Ayarları")
        score_layout = QFormLayout(score_group)
        self._add_spin('min_score', "Min Onay Skoru:", 1, 4, defaults['min_score'], score_layout)
        self._add_spin('exit_score', "Çıkış Hassasiyeti:", 1, 4, defaults['exit_score'], score_layout)
        self.params_layout.addWidget(score_group)
        
        # ARS Ayarları
        ars_group = QGroupBox("📈 ARS Parametreleri")
        ars_layout = QFormLayout(ars_group)
        self._add_spin('ars_period', "ARS Periyot:", 2, 20, defaults['ars_period'], ars_layout)
        self._add_double_spin('ars_k', "ARS K:", 0.001, 0.1, defaults['ars_k'], ars_layout, 3)
        self.params_layout.addWidget(ars_group)
        
        # ADX Ayarları
        adx_group = QGroupBox("📉 ADX Parametreleri")
        adx_layout = QFormLayout(adx_group)
        self._add_spin('adx_period', "ADX Periyot:", 5, 30, defaults['adx_period'], adx_layout)
        self._add_double_spin('adx_threshold', "ADX Eşik:", 10, 50, defaults['adx_threshold'], adx_layout)
        self.params_layout.addWidget(adx_group)
        
        # MACD-V Ayarları
        macdv_group = QGroupBox("📊 MACD-V Parametreleri")
        macdv_layout = QFormLayout(macdv_group)
        self._add_spin('macdv_short', "Kısa Periyot:", 5, 20, defaults['macdv_short'], macdv_layout)
        self._add_spin('macdv_long', "Uzun Periyot:", 15, 50, defaults['macdv_long'], macdv_layout)
        self._add_spin('macdv_signal', "Sinyal Periyot:", 5, 20, defaults['macdv_signal'], macdv_layout)
        self.params_layout.addWidget(macdv_group)
        
        # NetLot Ayarları
        netlot_group = QGroupBox("💰 NetLot Parametreleri")
        netlot_layout = QFormLayout(netlot_group)
        self._add_double_spin('netlot_threshold', "NetLot Eşik:", 0, 100, defaults['netlot_threshold'], netlot_layout)
        self.params_layout.addWidget(netlot_group)
        
        # Yatay Filtre
        filter_group = QGroupBox("🔲 Yatay Filtre")
        filter_layout = QFormLayout(filter_group)
        self._add_spin('yatay_ars_bars', "ARS Bar Sayısı:", 5, 30, defaults['yatay_ars_bars'], filter_layout)
        self._add_double_spin('ars_mesafe_threshold', "ARS Mesafe Eşik:", 0.1, 1.0, defaults['ars_mesafe_threshold'], filter_layout)
        self._add_spin('bb_period', "BB Periyot:", 10, 50, defaults['bb_period'], filter_layout)
        self._add_double_spin('bb_std', "BB StdDev:", 1.0, 3.0, defaults['bb_std'], filter_layout)
        self._add_double_spin('bb_width_multiplier', "BB Genişlik Çarpanı:", 0.5, 1.5, defaults['bb_width_multiplier'], filter_layout)
        self._add_spin('filter_score_threshold', "Filtre Skor Eşik:", 1, 4, defaults['filter_score_threshold'], filter_layout)
        self.params_layout.addWidget(filter_group)
        
        self.params_layout.addStretch()
    
    def _create_strategy2_params(self):
        """Strateji 2 parametrelerini oluştur"""
        defaults = self.STRATEGY2_DEFAULTS
        
        # ARS Ayarları
        ars_group = QGroupBox("📈 ARS Parametreleri")
        ars_layout = QFormLayout(ars_group)
        self._add_spin('ars_ema_period', "EMA Periyot:", 2, 20, defaults['ars_ema_period'], ars_layout)
        self._add_spin('ars_atr_period', "ATR Periyot:", 5, 30, defaults['ars_atr_period'], ars_layout)
        self._add_double_spin('ars_atr_mult', "ATR Çarpan:", 0, 2, defaults['ars_atr_mult'], ars_layout)
        self._add_double_spin('ars_min_band', "Min Band:", 0.001, 0.05, defaults['ars_min_band'], ars_layout, 3)
        self._add_double_spin('ars_max_band', "Max Band:", 0.005, 0.1, defaults['ars_max_band'], ars_layout, 3)
        self.params_layout.addWidget(ars_group)
        
        # Giriş Filtreleri
        entry_group = QGroupBox("🎯 Giriş Filtreleri")
        entry_layout = QFormLayout(entry_group)
        self._add_spin('momentum_period', "Momentum Periyot:", 3, 20, defaults['momentum_period'], entry_layout)
        self._add_spin('breakout_period', "Breakout Periyot:", 5, 30, defaults['breakout_period'], entry_layout)
        self._add_spin('mfi_period', "MFI Periyot:", 7, 30, defaults['mfi_period'], entry_layout)
        self._add_spin('mfi_hhv_period', "MFI HHV Periyot:", 7, 30, defaults['mfi_hhv_period'], entry_layout)
        self._add_spin('volume_hhv_period', "Volume HHV Periyot:", 7, 30, defaults['volume_hhv_period'], entry_layout)
        self.params_layout.addWidget(entry_group)
        
        # ATR Çıkış
        exit_group = QGroupBox("🚪 ATR Çıkış Parametreleri")
        exit_layout = QFormLayout(exit_group)
        self._add_spin('atr_exit_period', "ATR Periyot:", 7, 30, defaults['atr_exit_period'], exit_layout)
        self._add_double_spin('atr_sl_mult', "Stop Loss Çarpan:", 1, 5, defaults['atr_sl_mult'], exit_layout)
        self._add_double_spin('atr_tp_mult', "Take Profit Çarpan:", 2, 10, defaults['atr_tp_mult'], exit_layout)
        self._add_double_spin('atr_trail_mult', "Trailing Çarpan:", 1, 5, defaults['atr_trail_mult'], exit_layout)
        self._add_spin('exit_confirm_bars', "Onay Bar Sayısı:", 1, 5, defaults['exit_confirm_bars'], exit_layout)
        self._add_double_spin('exit_confirm_mult', "Onay Mesafe Çarpanı:", 0.5, 3, defaults['exit_confirm_mult'], exit_layout)
        self.params_layout.addWidget(exit_group)
        
        self.params_layout.addStretch()

    def _create_strategy3_params(self):
        """Strateji 3 (Paradise) parametrelerini oluştur"""
        defaults = self.STRATEGY3_DEFAULTS
        
        # Trend
        trend_group = QGroupBox("📈 Trend Filtreleri")
        trend_layout = QFormLayout(trend_group)
        self._add_spin('ema_period', "EMA Periyot:", 5, 100, defaults['ema_period'], trend_layout)
        self._add_spin('dsma_period', "DSMA Periyot:", 10, 200, defaults['dsma_period'], trend_layout)
        self._add_spin('ma_period', "MA Periyot:", 5, 100, defaults['ma_period'], trend_layout)
        self.params_layout.addWidget(trend_group)
        
        # Breakout
        bo_group = QGroupBox("🚀 Breakout Ayarları")
        bo_layout = QFormLayout(bo_group)
        self._add_spin('hh_period', "HH/LL Periyot:", 5, 100, defaults['hh_period'], bo_layout)
        self._add_spin('vol_hhv_period', "Hacim HHV Periyot:", 5, 50, defaults['vol_hhv_period'], bo_layout)
        self.params_layout.addWidget(bo_group)
        
        # Momentum
        mom_group = QGroupBox("⚡ Momentum Bandı")
        mom_layout = QFormLayout(mom_group)
        self._add_spin('mom_period', "Momentum Periyot:", 10, 200, defaults['mom_period'], mom_layout)
        self._add_double_spin('mom_alt', "Alt Eşik (100 - X):", 90.0, 100.0, defaults['mom_alt'], mom_layout)
        self._add_double_spin('mom_ust', "Üst Eşik (100 + X):", 100.0, 110.0, defaults['mom_ust'], mom_layout)
        self.params_layout.addWidget(mom_group)
        
        # Risk / Çıkış
        risk_group = QGroupBox("🛡️ Risk & Çıkış")
        risk_layout = QFormLayout(risk_group)
        self._add_spin('atr_period', "ATR Periyot:", 5, 50, defaults['atr_period'], risk_layout)
        self._add_double_spin('atr_sl', "ATR Stop Loss:", 0.5, 10.0, defaults['atr_sl'], risk_layout)
        self._add_double_spin('atr_tp', "ATR Take Profit:", 1.0, 20.0, defaults['atr_tp'], risk_layout)
        self._add_double_spin('atr_trail', "ATR Trailing Stop:", 0.5, 10.0, defaults['atr_trail'], risk_layout)
        self.params_layout.addWidget(risk_group)
        
        self.params_layout.addStretch()

    def _create_strategy4_params(self):
        """Strateji 4 (TOMA) parametrelerini oluştur"""
        defaults = self.STRATEGY4_DEFAULTS
        
        # TOMA & Layer 3
        toma_group = QGroupBox("📈 TOMA (Layer 3 - Trend)")
        toma_layout = QFormLayout(toma_group)
        self._add_spin('toma_period', "TOMA Periyot:", 1, 3, defaults.get('toma_period', 2), toma_layout)
        self._add_double_spin('toma_opt', "TOMA Opt %:", 0.1, 3.0, defaults.get('toma_opt', 2.1), toma_layout)
        self._add_spin('hhv1_period', "Filtre HHV:", 10, 100, defaults.get('hhv1_period', 20), toma_layout)
        self._add_spin('llv1_period', "Filtre LLV:", 10, 100, defaults.get('llv1_period', 20), toma_layout)
        self.params_layout.addWidget(toma_group)
        
        # Global Indikatorler
        global_group = QGroupBox("🌍 Global Indikatorler")
        global_layout = QFormLayout(global_group)
        self._add_spin('mom_period', "Momentum P:", 100, 5000, defaults.get('mom_period', 1900), global_layout)
        self._add_spin('trix_period', "TRIX P:", 10, 200, defaults.get('trix_period', 120), global_layout)
        self.params_layout.addWidget(global_group)
        
        # Layer 1 (Mom High)
        l1_group = QGroupBox("🚀 Momentum High (Layer 1)")
        l1_layout = QFormLayout(l1_group)
        self._add_double_spin('mom_limit_high', "Mom High Eşik >", 90.0, 110.0, defaults.get('mom_limit_high', 101.5), l1_layout)
        self._add_spin('trix_lb1', "TRIX LB (High):", 50, 200, defaults.get('trix_lb1', 145), l1_layout)
        self._add_spin('hhv2_period', "L1 HHV:", 50, 500, defaults.get('hhv2_period', 150), l1_layout)
        self._add_spin('llv2_period', "L1 LLV:", 50, 500, defaults.get('llv2_period', 190), l1_layout)
        self.params_layout.addWidget(l1_group)
        
        # Layer 2 (Mom Low)
        l2_group = QGroupBox("📉 Momentum Low (Layer 2)")
        l2_layout = QFormLayout(l2_group)
        self._add_double_spin('mom_limit_low', "Mom Low Eşik <", 90.0, 110.0, defaults.get('mom_limit_low', 99.0), l2_layout)
        self._add_spin('trix_period2', "TRIX2 P (Low):", 10, 200, defaults.get('trix_period2', 100), l2_layout)
        self._add_spin('trix_lb2', "TRIX LB (Low):", 50, 200, defaults.get('trix_lb2', 160), l2_layout)
        self._add_spin('hhv3_period', "L2 HHV:", 50, 500, defaults.get('hhv3_period', 150), l2_layout)
        self._add_spin('llv3_period', "L2 LLV:", 50, 500, defaults.get('llv3_period', 190), l2_layout)
        self.params_layout.addWidget(l2_group)
        
        # Risk
        risk_group = QGroupBox("🛡️ Risk & Çıkış")
        risk_layout = QFormLayout(risk_group)
        self._add_double_spin('kar_al', "Kar Al %:", 0.0, 20.0, defaults.get('kar_al', 0.0), risk_layout)
        self._add_double_spin('iz_stop', "İzleyen Stop %:", 0.0, 10.0, defaults.get('iz_stop', 0.0), risk_layout)
        self.params_layout.addWidget(risk_group)
        
        self.params_layout.addStretch()
    
    def _create_strategy5_params(self):
        """Strateji 5 (Oliver Kell) parametrelerini oluştur"""
        defaults = self.STRATEGY5_DEFAULTS
        
        # EMA Trend
        trend_group = QGroupBox("📈 EMA Trend")
        trend_layout = QFormLayout(trend_group)
        self._add_spin('ema_fast', "EMA Hızlı:", 5, 20, defaults['ema_fast'], trend_layout)
        self._add_spin('ema_slow', "EMA Yavaş:", 10, 50, defaults['ema_slow'], trend_layout)
        self.params_layout.addWidget(trend_group)
        
        # Breakout
        bo_group = QGroupBox("🚀 Kırılım")
        bo_layout = QFormLayout(bo_group)
        self._add_spin('breakout_period', "Kırılım Periyot:", 5, 30, defaults['breakout_period'], bo_layout)
        self.params_layout.addWidget(bo_group)
        
        # Chop Filter
        chop_group = QGroupBox("🔲 Testere (Chop) Filtresi")
        chop_layout = QFormLayout(chop_group)
        self._add_spin('adx_period', "ADX Periyot:", 7, 30, defaults['adx_period'], chop_layout)
        self._add_double_spin('adx_threshold', "ADX Sınır:", 10.0, 35.0, defaults['adx_threshold'], chop_layout)
        self._add_spin('vol_ma_period', "Hacim MA Periyot:", 5, 40, defaults['vol_ma_period'], chop_layout)
        self.params_layout.addWidget(chop_group)
        
        # Risk
        risk_group = QGroupBox("🛡️ İz Süren Stop")
        risk_layout = QFormLayout(risk_group)
        self._add_double_spin('trailing_stop_pct', "Trailing Stop %:", 0.5, 5.0, defaults['trailing_stop_pct'], risk_layout)
        self.params_layout.addWidget(risk_group)
        
        self.params_layout.addStretch()
    
    def _create_strategy6_params(self):
        """Strateji 6 (TOTT_HOTT) parametrelerini olustur"""
        defaults = self.STRATEGY6_DEFAULTS
        
        # Trend (OTT)
        trend_group = QGroupBox("OTT Trend")
        trend_layout = QFormLayout(trend_group)
        self._add_spin('ott_period', "OTT Periyot:", 10, 100, defaults['ott_period'], trend_layout)
        self._add_double_spin('ott_pct_big', "OTT % Buyuk:", 3.0, 15.0, defaults['ott_pct_big'], trend_layout)
        self._add_double_spin('ott_pct_small', "OTT % Kucuk:", 0.5, 6.0, defaults['ott_pct_small'], trend_layout)
        self.params_layout.addWidget(trend_group)
        
        # Bolge
        bolge_group = QGroupBox("Bolge Filtreleri")
        bolge_layout = QFormLayout(bolge_group)
        self._add_double_spin('ott_mult', "OTT Bant Carpan:", 0.0001, 0.005, defaults['ott_mult'], bolge_layout, 4)
        self._add_double_spin('sott_pct', "SOTT %:", 0.1, 1.0, defaults['sott_pct'], bolge_layout)
        self.params_layout.addWidget(bolge_group)
        
        # Kapi
        gate_group = QGroupBox("Kapi Filtreleri")
        gate_layout = QFormLayout(gate_group)
        self._add_spin('gate_period', "Gate Periyot:", 5, 50, defaults['gate_period'], gate_layout)
        self._add_double_spin('gate_pct', "Gate %:", 0.1, 2.0, defaults['gate_pct'], gate_layout)
        self.params_layout.addWidget(gate_group)
        
        self.params_layout.addStretch()
        
    def _create_strategy7_params(self):
        """Strateji 7 (DeepScalp) parametrelerini olustur"""
        defaults = self.STRATEGY7_DEFAULTS
        
        # Layer 1
        l1_group = QGroupBox("Layer 1: Risk & Regime")
        l1_layout = QFormLayout(l1_group)
        self._add_double_spin('ars_k', "ARS Bant Carpan:", 0.5, 3.0, defaults['ars_k'], l1_layout)
        self._add_double_spin('atr_stop_mult_long', "ATR SL Long:", 0.5, 5.0, defaults['atr_stop_mult_long'], l1_layout)
        self._add_double_spin('atr_stop_mult_short', "ATR SL Short:", 0.5, 5.0, defaults['atr_stop_mult_short'], l1_layout)
        self._add_double_spin('kar_al_yuzde_long', "Kar Al % Long:", 0.5, 10.0, defaults['kar_al_yuzde_long'], l1_layout)
        self._add_double_spin('kar_al_yuzde_short', "Kar Al % Short:", 0.5, 10.0, defaults['kar_al_yuzde_short'], l1_layout)
        self._add_spin('hhv_period', "Tekil Kirici HHV:", 5, 50, defaults['hhv_period'], l1_layout)
        self._add_spin('llv_period', "Tekil Kirici LLV:", 5, 50, defaults['llv_period'], l1_layout)
        self._add_double_spin('vol_ratio', "Hacim Orani:", 0.1, 2.0, defaults['vol_ratio'], l1_layout)
        self.params_layout.addWidget(l1_group)
        
        # Layer 2
        l2_group = QGroupBox("Layer 2: Trend & MFI Limit")
        l2_layout = QFormLayout(l2_group)
        self._add_double_spin('st_factor', "SuperTrend Factor:", 0.5, 10.0, defaults['st_factor'], l2_layout)
        self._add_spin('ema_fast_period', "EMA Hizli:", 3, 50, defaults['ema_fast_period'], l2_layout)
        self._add_spin('ema_slow_period', "EMA Yavas:", 5, 100, defaults['ema_slow_period'], l2_layout)
        self._add_spin('mfi_hhv_period', "MFI HHV:", 3, 30, defaults['mfi_hhv_period'], l2_layout)
        self._add_spin('mfi_llv_period', "MFI LLV:", 3, 30, defaults['mfi_llv_period'], l2_layout)
        self.params_layout.addWidget(l2_group)
        
        # Layer 3
        l3_group = QGroupBox("Layer 3: Zamanlama & Tetikleme")
        l3_layout = QFormLayout(l3_group)
        self._add_double_spin('toma_period2', "TOMA Yuzde:", 0.1, 10.0, defaults['toma_period2'], l3_layout)
        self._add_double_spin('mfi_long', "MFI Long Limit:", 10.0, 90.0, defaults['mfi_long'], l3_layout)
        self._add_double_spin('mfi_short', "MFI Short Limit:", 10.0, 90.0, defaults['mfi_short'], l3_layout)
        self.params_layout.addWidget(l3_group)
        
        # Layer 4
        l4_group = QGroupBox("Layer 4: Zaman Filtreleri")
        l4_layout = QFormLayout(l4_group)
        self._add_spin('min_hold_bars', "Min Hold Bar:", 1, 10, defaults['min_hold_bars'], l4_layout)
        self._add_spin('max_hold_bars', "Max Hold Bar:", 5, 100, defaults['max_hold_bars'], l4_layout)
        self._add_spin('cooldown_bars', "Cooldown Bar:", 1, 10, defaults['cooldown_bars'], l4_layout)
        self.params_layout.addWidget(l4_group)
        
        self.params_layout.addStretch()

    def _create_strategy8_params(self):
        """Strateji 8 (Gap Reversal) parametrelerini olustur"""
        defaults = self.STRATEGY8_DEFAULTS

        # Gap Filtre
        gap_group = QGroupBox("Katman 1: Gap Filtre")
        gap_layout = QFormLayout(gap_group)
        self._add_double_spin('min_gap_pct', "Min Gap %:", 0.01, 1.0, defaults['min_gap_pct'], gap_layout, decimals=2)
        self._add_double_spin('max_gap_pct', "Max Gap %:", 0.5, 5.0, defaults['max_gap_pct'], gap_layout, decimals=2)
        self.params_layout.addWidget(gap_group)

        # Opening Range
        or_group = QGroupBox("Katman 2: Opening Range")
        or_layout = QFormLayout(or_group)
        self._add_spin('or_bars', "OR Bar Sayisi:", 5, 60, defaults['or_bars'], or_layout)
        self.params_layout.addWidget(or_group)

        # RSI
        rsi_group = QGroupBox("Katman 4: RSI Onay")
        rsi_layout = QFormLayout(rsi_group)
        self._add_spin('rsi_period', "RSI Periyot:", 3, 20, defaults['rsi_period'], rsi_layout)
        self._add_double_spin('rsi_ob', "RSI Overbought (Short):", 50.0, 90.0, defaults['rsi_ob'], rsi_layout)
        self._add_double_spin('rsi_os', "RSI Oversold (Long):", 10.0, 50.0, defaults['rsi_os'], rsi_layout)
        self.params_layout.addWidget(rsi_group)

        # Hacim
        vol_group = QGroupBox("Katman 5: Hacim Onay")
        vol_layout = QFormLayout(vol_group)
        self._add_spin('hacim_ma_period', "Hacim MA Periyot:", 5, 50, defaults['hacim_ma_period'], vol_layout)
        self._add_double_spin('hacim_oran', "Hacim Orani:", 0.1, 2.0, defaults['hacim_oran'], vol_layout)
        self.params_layout.addWidget(vol_group)

        # ATR & Zaman
        risk_group = QGroupBox("Katman 6-8: ATR Stop & Zaman")
        risk_layout = QFormLayout(risk_group)
        self._add_spin('atr_period', "ATR Periyot:", 5, 30, defaults['atr_period'], risk_layout)
        self._add_double_spin('atr_stop_mult', "ATR Stop Carpan:", 0.1, 3.0, defaults['atr_stop_mult'], risk_layout)
        self._add_spin('gap_window_bars', "Zaman Stopu (Bar):", 30, 420, defaults['gap_window_bars'], risk_layout)
        self._add_spin('cooldown_bars', "Cooldown Bar:", 1, 10, defaults['cooldown_bars'], risk_layout)
        self.params_layout.addWidget(risk_group)

        self.params_layout.addStretch()

    def _add_spin(self, name: str, label: str, min_val: int, max_val: int, default: int, layout: QFormLayout):
        """Integer SpinBox ekle"""
        spin = QSpinBox()
        spin.setRange(min_val, max_val)
        spin.setValue(default)
        self.param_widgets[name] = spin
        layout.addRow(label, spin)
    
    def _add_double_spin(self, name: str, label: str, min_val: float, max_val: float, default: float, layout: QFormLayout, decimals: int = 2):
        """Double SpinBox ekle"""
        spin = QDoubleSpinBox()
        spin.setRange(min_val, max_val)
        spin.setDecimals(decimals)
        spin.setSingleStep(0.1 if decimals <= 2 else 0.001)
        spin.setValue(default)
        self.param_widgets[name] = spin
        layout.addRow(label, spin)
    
    def _reset_to_defaults(self):
        """Varsayılan değerlere dön"""
        index = self.strategy_combo.currentIndex()
        if index == 0:
            defaults = self.STRATEGY1_DEFAULTS
        elif index == 1:
            defaults = self.STRATEGY2_DEFAULTS
        elif index == 2:
            defaults = self.STRATEGY3_DEFAULTS
        elif index == 3:
            defaults = self.STRATEGY4_DEFAULTS
        elif index == 4:
            defaults = self.STRATEGY5_DEFAULTS
        elif index == 5:
            defaults = self.STRATEGY6_DEFAULTS
        elif index == 6:
            defaults = self.STRATEGY7_DEFAULTS
        elif index == 7:
            defaults = self.STRATEGY8_DEFAULTS
        else:
            defaults = self.STRATEGY1_DEFAULTS
        
        for name, widget in self.param_widgets.items():
            if name in defaults:
                widget.setValue(defaults[name])
    
    def _load_preset(self):
        """Preset yükle"""
        from PySide6.QtWidgets import QFileDialog
        import json
        
        preset_dir = Path(__file__).parent.parent.parent.parent / "presets"
        preset_dir.mkdir(exist_ok=True)
        
        filepath, _ = QFileDialog.getOpenFileName(
            self, "Preset Yükle", str(preset_dir), "JSON Files (*.json)"
        )
        
        if filepath:
            try:
                with open(filepath, 'r', encoding='utf-8') as f:
                    preset = json.load(f)
                
                # Strateji seç
                if 'strategy' in preset:
                    self.strategy_combo.setCurrentIndex(preset['strategy'] - 1)
                
                # Vade tipi
                if 'vade_tipi' in preset:
                    self.vade_combo.setCurrentText(preset['vade_tipi'])
                
                # Parametreleri yükle
                for name, value in preset.items():
                    if name in self.param_widgets:
                        self.param_widgets[name].setValue(value)
                
                QMessageBox.information(self, "Başarılı", f"Preset yüklendi: {Path(filepath).stem}")
            except Exception as e:
                QMessageBox.warning(self, "Hata", f"Preset yüklenemedi: {e}")
    
    def _save_preset(self):
        """Preset kaydet"""
        from PySide6.QtWidgets import QFileDialog
        import json
        
        preset_dir = Path(__file__).parent.parent.parent.parent / "presets"
        preset_dir.mkdir(exist_ok=True)
        
        # Varsayılan isim
        idx = self.strategy_combo.currentIndex()
        if idx == 0:
            strategy_name = "strateji1"
        elif idx == 1:
            strategy_name = "strateji2"
        elif idx == 2:
            strategy_name = "paradise"
        elif idx == 3:
            strategy_name = "strateji4"
        elif idx == 4:
            strategy_name = "oliver_kell"
        elif idx == 5:
            strategy_name = "tott_hott"
        elif idx == 6:
            strategy_name = "deepscalp"
        elif idx == 7:
            strategy_name = "gap_reversal"
        else:
            strategy_name = "unknown"
        default_name = f"{strategy_name}_preset.json"
        
        filepath, _ = QFileDialog.getSaveFileName(
            self, "Preset Kaydet", str(preset_dir / default_name), "JSON Files (*.json)"
        )
        
        if filepath:
            try:
                config = self.get_config()
                with open(filepath, 'w', encoding='utf-8') as f:
                    json.dump(config, f, indent=2, ensure_ascii=False)
                
                QMessageBox.information(self, "Başarılı", f"Preset kaydedildi: {Path(filepath).name}")
            except Exception as e:
                QMessageBox.warning(self, "Hata", f"Preset kaydedilemedi: {e}")
    
    def _apply_config(self):
        """Konfigürasyonu uygula"""
        config = self.get_config()
        self.config_changed.emit(config)
        QMessageBox.information(self, "Uygulama", f"✅ {len(config)} parametre uygulandı.")
    
    def get_config(self) -> dict:
        """Mevcut konfigürasyonu döndür"""
        config = {
            'strategy': self.strategy_combo.currentIndex() + 1,
            'vade_tipi': self.vade_combo.currentText(),
        }
        
        for name, widget in self.param_widgets.items():
            config[name] = widget.value()
        
        return config
    
    def set_data(self, df):
        """Veri set et (DataPanel'den sinyal)"""
        self.df = df
    
    def _run_manual_backtest(self):
        """Manuel backtest calistir"""
        if self.df is None or len(self.df) == 0:
            QMessageBox.warning(self, "Uyari", "Lutfen once veri yukleyin.")
            return
        
        try:
            config = self.get_config()
            strategy_idx = config['strategy']
            
            self.backtest_result_label.setText("Backtest calisiyor...")
            self.backtest_btn.setEnabled(False)
            
            # Gerekli verileri hazirla
            df = self.df
            opens = df['Acilis'].tolist() if 'Acilis' in df.columns else df['Open'].tolist()
            highs = df['Yuksek'].tolist() if 'Yuksek' in df.columns else df['High'].tolist()
            lows = df['Dusuk'].tolist() if 'Dusuk' in df.columns else df['Low'].tolist()
            closes = df['Kapanis'].tolist() if 'Kapanis' in df.columns else df['Close'].tolist()
            typical = df['Tipik'].tolist() if 'Tipik' in df.columns else [(h+l+c)/3 for h,l,c in zip(highs,lows,closes)]
            dates = df['DateTime'].tolist() if 'DateTime' in df.columns else None
            
            if strategy_idx == 1:
                from src.strategies.score_based import ScoreBasedStrategy
                strategy = ScoreBasedStrategy.from_config_dict(
                    {'opens': opens, 'highs': highs, 'lows': lows, 'closes': closes, 'typical': typical, 'dates': dates},
                    config,
                    dates
                )
            elif strategy_idx == 3:
                from src.strategies.paradise_strategy import ParadiseStrategy
                strategy = ParadiseStrategy.from_config_dict(
                    {'opens': opens, 'highs': highs, 'lows': lows, 'closes': closes, 'typical': typical, 'dates': dates},
                    config,
                    dates
                )
            elif strategy_idx == 4:
                from src.strategies.toma_strategy import TomaStrategy
                strategy = TomaStrategy.from_config_dict(
                    {'opens': opens, 'highs': highs, 'lows': lows, 'closes': closes, 'typical': typical, 'dates': dates},
                    config,
                    dates
                )
            elif strategy_idx == 5:
                from src.strategies.oliver_kell_s5 import OliverKellStrategy
                strategy = OliverKellStrategy.from_config_dict(
                    {'opens': opens, 'highs': highs, 'lows': lows, 'closes': closes, 'typical': typical, 'volumes': df['Lot'].tolist() if 'Lot' in df.columns else df['Volume'].tolist(), 'dates': dates},
                    config,
                    dates
                )
            elif strategy_idx == 6:
                from src.strategies.tott_hott_strategy import TOTT_HOTTStrategy
                strategy = TOTT_HOTTStrategy.from_config_dict(
                    {'opens': opens, 'highs': highs, 'lows': lows, 'closes': closes, 'typical': typical, 'volumes': df['Lot'].tolist() if 'Lot' in df.columns else df['Volume'].tolist(), 'dates': dates},
                    config,
                    dates
                )
            elif strategy_idx == 7:
                from src.strategies.deepscalp_strategy import DeepScalpStrategy
                strategy = DeepScalpStrategy.from_config_dict(
                    {'opens': opens, 'highs': highs, 'lows': lows, 'closes': closes, 'typical': typical, 'volumes': df['Lot'].tolist() if 'Lot' in df.columns else df['Volume'].tolist(), 'dates': dates},
                    config,
                    dates
                )
            elif strategy_idx == 8:
                from src.strategies.gap_reversal_strategy import GapReversalStrategy
                strategy = GapReversalStrategy.from_config_dict(
                    {'opens': opens, 'highs': highs, 'lows': lows, 'closes': closes, 'typical': typical, 'volumes': df['Lot'].tolist() if 'Lot' in df.columns else df['Volume'].tolist(), 'dates': dates},
                    config,
                    dates
                )
            else:
                from src.strategies.ars_trend_v2 import ARSTrendStrategyV2
                strategy = ARSTrendStrategyV2.from_config_dict(
                    {'opens': opens, 'highs': highs, 'lows': lows, 'closes': closes, 'typical': typical, 'dates': dates},
                    config,
                    dates
                )
            
            # Sinyalleri uret
            signals, exits_long, exits_short = strategy.generate_all_signals()
            
            # Basit backtest
            import numpy as np
            position = 0  # 0=flat, 1=long, -1=short
            entry_price = 0
            trades = []
            
            for i in range(len(closes)):
                if position == 0:
                    if signals[i] == 1:
                        position = 1
                        entry_price = closes[i]
                    elif signals[i] == -1:
                        position = -1
                        entry_price = closes[i]
                elif position == 1:
                    if exits_long[i] or signals[i] == -1:
                        pnl = closes[i] - entry_price
                        trades.append(pnl)
                        position = 0 if exits_long[i] else -1
                        entry_price = closes[i] if signals[i] == -1 else 0
                elif position == -1:
                    if exits_short[i] or signals[i] == 1:
                        pnl = entry_price - closes[i]
                        trades.append(pnl)
                        position = 0 if exits_short[i] else 1
                        entry_price = closes[i] if signals[i] == 1 else 0
            
            # Metrikleri hesapla
            if len(trades) == 0:
                self.backtest_result_label.setText("Hic islem bulunamadi.")
                self.backtest_btn.setEnabled(True)
                return
            
            trades_arr = np.array(trades)
            total_profit = np.sum(trades_arr)
            win_count = np.sum(trades_arr > 0)
            loss_count = np.sum(trades_arr < 0)
            win_rate = win_count / len(trades_arr) * 100
            
            gross_profit = np.sum(trades_arr[trades_arr > 0]) if win_count > 0 else 0
            gross_loss = abs(np.sum(trades_arr[trades_arr < 0])) if loss_count > 0 else 0
            profit_factor = gross_profit / gross_loss if gross_loss > 0 else float('inf')
            
            # Max drawdown
            equity = np.cumsum(trades_arr)
            peak = np.maximum.accumulate(equity)
            drawdown = peak - equity
            max_dd = np.max(drawdown) if len(drawdown) > 0 else 0
            
            result_text = f"""
BACKTEST SONUCLARI
==================
Toplam Islem: {len(trades)}
Kazanan: {win_count} | Kaybeden: {loss_count}
Win Rate: {win_rate:.1f}%

Net Kar: {total_profit:.0f} puan
Profit Factor: {profit_factor:.2f}
Max Drawdown: {max_dd:.0f} puan

Ortalama Kar: {np.mean(trades_arr):.1f} puan/islem
"""
            
            self.backtest_result_label.setText(result_text.strip())
            self.backtest_btn.setEnabled(True)
            
        except Exception as e:
            QMessageBox.critical(self, "Hata", f"Backtest hatasi: {str(e)}")
            self.backtest_btn.setEnabled(True)

