# -*- coding: utf-8 -*-
from PySide6.QtWidgets import (
    QWidget, QVBoxLayout, QHBoxLayout, QPushButton, QLabel, 
    QFileDialog, QTableWidget, QTableWidgetItem, QHeaderView,
    QProgressBar, QMessageBox, QGroupBox
)
from PySide6.QtCore import Qt, QThread, Signal
import pandas as pd
import os
import sys

# Ensure parent directory is in path for imports
sys.path.append(os.path.abspath(os.path.join(os.path.dirname(__file__), '..', '..')))
from src.optimization.robust_analyzer import RobustAnalyzer

class AnalysisWorker(QThread):
    finished = Signal(pd.DataFrame, str)
    error = Signal(str)
    
    def __init__(self, file_path):
        super().__init__()
        self.file_path = file_path
        
    def run(self):
        try:
            analyzer = RobustAnalyzer(self.file_path)
            analyzer.load_and_parse()
            analyzer.run_robust_analysis()
            
            # Get recommended params
            df_rec = analyzer.processed_df[analyzer.processed_df['robust_fitness'] > 0].sort_values('robust_fitness', ascending=False).head(20)
            
            # Export report to local dir as well
            report_path = analyzer.export_report()
            
            self.finished.emit(df_rec, report_path)

        except Exception as e:
            self.error.emit(str(e))

class RobustnessPanel(QWidget):
    """Harici Optimizasyon Dosyası Analiz Paneli"""
    
    def __init__(self):
        super().__init__()
        self._setup_ui()
        
    def _setup_ui(self):
        layout = QVBoxLayout(self)
        layout.setSpacing(15)
        
        # Dosya Seçimi Grubu
        file_group = QGroupBox("İdeal Data Optimizasyon Dosyası (Excel/CSV)")
        file_layout = QHBoxLayout(file_group)
        
        self.file_label = QLabel("Dosya seçilmedi...")
        self.file_label.setStyleSheet("color: #888; font-style: italic;")
        file_layout.addWidget(self.file_label, 1)
        
        self.select_btn = QPushButton("Dosya Seç")
        self.select_btn.clicked.connect(self._select_file)
        file_layout.addWidget(self.select_btn)
        
        self.analyze_btn = QPushButton("Analiz Et (Robustness)")
        self.analyze_btn.setObjectName("primaryButton")
        self.analyze_btn.setEnabled(False)
        self.analyze_btn.clicked.connect(self._run_analysis)
        file_layout.addWidget(self.analyze_btn)
        
        layout.addWidget(file_group)
        
        # İlerleme
        self.progress_bar = QProgressBar()
        self.progress_bar.setVisible(False)
        layout.addWidget(self.progress_bar)
        
        # Sonuçlar Grubu
        results_group = QGroupBox("Önerilen Parametreler (En Sağlam Kümeler)")
        results_layout = QVBoxLayout(results_group)
        
        self.results_table = QTableWidget()
        self.results_table.setColumnCount(6)
        self.results_table.setHorizontalHeaderLabels(["Parametreler", "Kâr", "DD", "PF", "Robust Skor", "Küme"])
        self.results_table.horizontalHeader().setSectionResizeMode(QHeaderView.Stretch)
        results_layout.addWidget(self.results_table)
        
        layout.addWidget(results_group, 1)
        
        # Alt Bilgi / Rapor Yolu
        self.footer_label = QLabel("")
        self.footer_label.setWordWrap(True)
        self.footer_label.setStyleSheet("color: #4CAF50; font-weight: bold;")
        layout.addWidget(self.footer_label)
        
    def _select_file(self):
        file_path, _ = QFileDialog.getOpenFileName(
            self, "Optimizasyon Dosyası Seç", "", "Excel/CSV Files (*.xlsx *.csv)"
        )
        if file_path:
            self.file_path = file_path
            self.file_label.setText(os.path.basename(file_path))
            self.file_label.setStyleSheet("color: #fff; font-style: normal;")
            self.analyze_btn.setEnabled(True)
            self.footer_label.setText("")
            
    def _run_analysis(self):
        self.progress_bar.setRange(0, 0)
        self.progress_bar.setVisible(True)
        self.analyze_btn.setEnabled(False)
        self.results_table.setRowCount(0)
        
        self.worker = AnalysisWorker(self.file_path)
        self.worker.finished.connect(self._on_analysis_finished)
        self.worker.error.connect(self._on_analysis_error)
        self.worker.start()
        
    def _on_analysis_finished(self, df_rec, report_path):
        self.progress_bar.setVisible(False)
        self.analyze_btn.setEnabled(True)
        
        # Tabloyu doldur
        self.results_table.setRowCount(len(df_rec))
        for i, (idx, row) in enumerate(df_rec.iterrows()):
            # Parametreler (Açıklama veya ayrılmış kolonlar)
            params = str(row.get('Açıklama', 'N/A'))
            if len(params) > 50: params = params[:47] + "..."
            
            self.results_table.setItem(i, 0, QTableWidgetItem(params))
            self.results_table.setItem(i, 1, QTableWidgetItem(f"{row.get('Kar Zarar', 0):,.2f}"))
            self.results_table.setItem(i, 2, QTableWidgetItem(f"{row.get('MaxDD', 0):,.2f}"))
            self.results_table.setItem(i, 3, QTableWidgetItem(f"{row.get('Profit Factor', 0):.2f}"))
            self.results_table.setItem(i, 4, QTableWidgetItem(f"{row.get('robust_fitness', 0):.2f}"))
            self.results_table.setItem(i, 5, QTableWidgetItem(str(row.get('cluster', '0'))))
            
        self.footer_label.setText(f"✓ Analiz Tamamlandı! Rapor oluşturuldu:\n{report_path}")
        QMessageBox.information(self, "Analiz Tamamlandı", f"En sağlam parametreler belirlendi ve rapor dışa aktarıldı.")
        
    def _on_analysis_error(self, error_msg):
        self.progress_bar.setVisible(False)
        self.analyze_btn.setEnabled(True)
        QMessageBox.critical(self, "Analiz Hatası", f"Hata oluştu: {error_msg}")
