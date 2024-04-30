# Primeiro instale a biblioteca PyYAML com o comando abaixo:
# pip install pyyaml

import yaml

# Dados a serem serializados em YAML
data = {
    'pessoas': [
        {'nome': 'Ana', 'idade': 25, 'cidade': 'São Paulo'},
        {'nome': 'João', 'idade': 30, 'cidade': 'Rio de Janeiro'}
    ]
}

# Serializar YAML e gravar em arquivo
with open('pessoas.yaml', 'w') as f:
    yaml.dump(data, f, default_flow_style=False)

print("Dados serializados em YAML no arquivo pessoas.yaml")
