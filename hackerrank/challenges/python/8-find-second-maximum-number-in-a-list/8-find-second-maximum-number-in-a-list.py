if __name__ == '__main__':

	n = int(input())

	arr =  list( map ( int, input().split()))

	arr.sort(reverse=True)

	if n >= 2 and n <= 10:

		top = -100
		second = -100

		for item in arr:

			if item >= top:
				top = item

			if item < top and item > second:
				second = item

		print(second)