from enum import Enum, auto

class SignalType(Enum):
    LONG = auto()
    SHORT = auto()
    FLAT = auto()
    EXIT_LONG = auto()
    EXIT_SHORT = auto()
