s = str(input())

s = s.split(" ")

a = int(s[0])
b = int(s[1])
c = int(s[2])
maior = 0

x = int((a+b+abs(a-b))/2)
if x > y: 
	maior = x


x = int((b+a+abs(b-a))/2)
if x > y: 
	maior = x


x = int((a+c+abs(a-c))/2)
if x > y: 
	maior = x


x = int((b+c+abs(b-c))/2)
if x > y: 
	maior = x

print(str(maior)+" eh o maior")