def changeAds(base10):
    string = ''
    b = ''

    a = bin(base10)[2:]
    a = int(a)
    a = str(a)
    print(a)
    for y in a:
        if y == '1':
            b = b + '0'
        elif y == '0':
            b = b + '1'


    print(b)
    
    number = int(b, 2)
    print(number)
    return number

if __name__ == '__main__':
    changeAds(50)
