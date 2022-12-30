ipts = input(str())
ipts = ipts.split(' ')

#iteract over each position and convert the element to int
idx = 0
for ipt in ipts:
 ipts[idx] = int(ipts[idx])
 print(ipts[idx])
 idx = idx + 1

if ((int(ipts[1]) > int(ipts[2])) and (int(ipts[3]) > int(ipts[0])) ):
	if( (ipts[2] + ipts[3]) > (ipts[0] + ipts[1])):
		if( (ipts[2] > 0) and (ipts[3] > 0) ):
			if (ipts[0] % 2 == 0):
				print("Valores aceitos");
			else:
				print("Valores nao aceitos");
		else:
			print("Valores nao aceitos");
	else:
		print("Valores nao aceitos");
else:
	print("Valores nao aceitos");
