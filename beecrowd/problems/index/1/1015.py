import math

l1 = str(input()).split(" ")
l2 = str(input()).split(" ")
x1 = float(l1[0])
y1 = float(l1[1])
x2 = float(l2[0])
y2 = float(l2[1])

print(float("{:.4f}".format(math.sqrt(math.pow((x2 - x1),2) + math.pow((y2 - y1),2)))))