import re

with open(r'd:\Projects\IdealQuant\src\strategies\S8_Gap_Strateji.txt', 'r', encoding='utf-8') as f:
    s8 = f.read()

# Let's count the number of { and }
print(f'{{ count: {s8.count("{")}, }} count: {s8.count("}")}')
