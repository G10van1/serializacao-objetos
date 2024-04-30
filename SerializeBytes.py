# Exemplo em Python de serialização para bytes
import pickle

dados = {'nome': 'Ana', 'idade': 25, 'cidade': 'São Paulo'}
dados_serializados = pickle.dumps(dados)

print(dados_serializados)
