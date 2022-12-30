i = int(input())

m = (i % 365)
d = m % 30
m = m-d
anos = int(i/365)
meses = int(m/30)
dias = int(d)

print(str(anos) + " ano(s)")
print(str(meses) + " mes(es)")
print(str(dias) + " dia(s)")