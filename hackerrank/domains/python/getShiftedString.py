def getShiftedString(s, leftShifts, rightShifts):
    # Write your code here

    my_list = []
    left = []
    right = []

    for char in s:
        my_list.append(char)

    index = 0
    while index < leftShifts:
        left.append(my_list[index])
        index = index +1

    result = my_list[leftShifts:]
    result = result + left

    print(result)

    index = len(my_list)-1
    while index >= rightShifts:
        right.append(my_list[index])
        index = index -1

    result = my_list[:rightShifts]
    result = right + result 

    print(result)


if __name__ == '__main__':
    getShiftedString('abcd', 1, 2)
