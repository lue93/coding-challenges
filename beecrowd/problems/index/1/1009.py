vendedor = str(input())
salario = float(str(input()).replace(',','.'))
vendas = float(str(input()).replace(',','.'))

total = salario + (vendas * 0.15)
total = "{:.2f}".format(total)
total = str(total).replace(',','.')
print("TOTAL = R$ " + total)
