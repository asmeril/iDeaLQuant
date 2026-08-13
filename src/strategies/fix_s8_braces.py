with open(r'd:\Projects\IdealQuant\src\strategies\S8_Gap_Strateji.txt', 'r', encoding='utf-8') as f:
    content = f.read()
    
content = content.replace('            }\n        }\n        }\n    }\n    else if', '            }\n        }\n    }\n    else if')
content = content.replace('            }\n        }\n        }\n    }\n    \n    if (Sinyal != ""', '            }\n        }\n    }\n    \n    if (Sinyal != ""')

with open(r'd:\Projects\IdealQuant\src\strategies\S8_Gap_Strateji.txt', 'w', encoding='utf-8') as f:
    f.write(content)
print('Fixed S8 braces')
