import math

S = str(input())
S = S.split(" ")

A = float(S[0])
B = float(S[1])
C = float(S[2])

base = 0 
y = 0
r = 0
lgc = True

try:
	delta = (B ** 2 - 4*A*C)
	sqrt = math.sqrt(delta)
	print("delta")
	print(delta)
	print("sqrt")
	print(sqrt)

	while (base <= delta):
		print("BASE")
		print(round(base));
		print("ELEVADO")
		print(y ** 2);
		y = y + 1;
		base = base + 1;

	if (y > 0):
		if (A > 0):
			R1 = ((-B) + (math.sqrt(delta))) / (2*A)
			print ("R1 = {:.5f}".format(R1))

			R2 = ((-B) - (math.sqrt(delta))) / (2*A)
			print ("R2 = {:.5f}".format(R2))
		else: 
			print("Impossível calcular")

except ValueError:
	print("Impossível calcular")


