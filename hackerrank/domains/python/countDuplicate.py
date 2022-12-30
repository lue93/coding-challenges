def countDuplicate(numbers):
    # Write your code here
    duplicate = 0

    y = 7
    x = 0

    z = 7
    k = 0
    while x < y:

        while z > k:
            if numbers[x] == numbers[z]:
                duplicate = duplicate + 1
            
            z = z - 1
            x = x + 1

    print(duplicate)
    return duplicate
if __name__ == '__main__':
    countDuplicate([1, 3, 1, 4, 5, 6, 3, 2])
