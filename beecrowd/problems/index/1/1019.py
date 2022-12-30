n = input()

h = (( int(n) / 60 ) / 60 ) # s / 60 = m / 60 = h

m = (( int(n) / 60 ) % 60 ) # s / 60 = m % 60 = m

s = ( int(n) % 60 )     # s % 60 = s

print('%.0d' % h + ':' + '%.0d' % m + ':' + '%.0d' % s);