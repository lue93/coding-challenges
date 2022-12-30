import os

valor = float('{:0.3f}'.format(float(input()))) #TODO

os.system('cls')

print("NOTAS:");
valora = valor % 100
valorb = valor / 100
print(str(int(valorb)) + " nota(s) de R$ 100.00");

valorc = valora % 50
valord = valora / 50
print(str(int(valord)) + " nota(s) de R$ 50.00");

valore = valorc % 20
valorf = valorc / 20
print(str(int(valorf)) + " nota(s) de R$ 20.00");

valorg = valore % 10
valorh = valore / 10
print(str(int(valorh)) + " nota(s) de R$ 10.00");

valori = valorg % 5
valorj = valorg / 5
print(str(int(valorj)) + " nota(s) de R$ 5.00");

valork = valori % 2
valorl = valori / 2
print(str(int(valorl)) + " nota(s) de R$ 2.00");

print("MOEDAS:");
valorm = valork % 1
valorn = valork / 1
print(str(int(valorn)) + " moeda(s) de R$ 1.00");

#0.50
valordv050 = valorm / 0.50
print (str(int(valordv050)) + " moeda(s) de R$ 0.50");
valordf050 = valorm % 0.50

#0.25
valordv025 = valordf050 / 0.25
print(str(int(valordv025)) + " moeda(s) de R$ 0.25");
valordf025 = valordf050 % 0.25

#0.10
valordv010 = valordf025 / 0.10
print(str(int(valordv010)) + " moeda(s) de R$ 0.10");
valordf010 = valordf025 % 0.10

#0.05
valordv005 = valordf010 / 0.05
print(str(int(valordv005)) + " moeda(s) de R$ 0.05");
valordf005 = valordf010 % 0.05

#0.01
valordv001 = valordf005 / 0.01
print(str(int(valordv001)) + " moeda(s) de R$ 0.01");
#valordf001 = valordf005 % 0.01