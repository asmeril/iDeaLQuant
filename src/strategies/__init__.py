# -*- coding: utf-8 -*-
"""IdealQuant Strategies Package"""

from .common import Signal
from .score_based import ScoreBasedStrategy, ScoreConfig
from .paradise_strategy import ParadiseStrategy, ParadiseConfig
from .gap_reversal_strategy import GapReversalStrategy, GapReversalConfig

__all__ = ['ARSTrendStrategy', 'StrategyConfig', 'Signal', 
           'ScoreBasedStrategy', 'ScoreConfig',
           'ParadiseStrategy', 'ParadiseConfig',
           'GapReversalStrategy', 'GapReversalConfig']
