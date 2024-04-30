import xml.etree.ElementTree as ET

# Dados a serem serializados em XML
pessoas = [
    {"nome": "Ana", "idade": 25, "cidade": "São Paulo"},
    {"nome": "João", "idade": 30, "cidade": "Rio de Janeiro"}
]

# Criar elemento raiz
root = ET.Element("pessoas")

# Adicionar elementos de pessoa ao XML
for pessoa in pessoas:
    pessoa_elem = ET.SubElement(root, "pessoa")
    for key, value in pessoa.items():
        ET.SubElement(pessoa_elem, key).text = str(value)

# Criar árvore XML e gravar em arquivo
tree = ET.ElementTree(root)
tree.write("pessoas.xml", encoding="utf-8", xml_declaration=True)

print("Dados serializados em XML no arquivo pessoas.xml")
