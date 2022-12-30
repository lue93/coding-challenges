valor = input()

print(valor)

valora = int(valor) % 100
valorb = int(valor) / 100
valorb = int(valorb)
print(valorb , "nota(s) de R$ 100,00")

valorc = valora % 50
valord = valora / 50
valord = int(valord)
print(valord , "nota(s) de R$ 50,00")

valore = valorc % 20
valorf = valorc / 20
valorf = int(valorf)
print(valorf , "nota(s) de R$ 20,00")

valorg = valore % 10
valorh = valore / 10
valorh = int(valorh)
print(valorh , "nota(s) de R$ 10,00")

valori = valorg % 5
valorj = valorg / 5
valorj = int(valorj)
print(valorj , "nota(s) de R$ 5,00")

valork = valori % 2
valorl = valori / 2
valorl = int(valorl)
print(valorl , "nota(s) de R$ 2,00")

valorm = valork % 1
valorn = valork / 1
valorn = int(valorn)
print(valorn , "nota(s) de R$ 1,00")