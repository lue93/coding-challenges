ipt = input()
string = ''
x = 1
y = int(ipt)

while x < y:
	string = string + "Ho "
	if x == (y-1):
		string = string + "Ho!"	
	x = x + 1

print(string)