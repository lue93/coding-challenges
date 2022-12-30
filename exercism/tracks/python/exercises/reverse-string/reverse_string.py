def reverse(text):

	my_list = []
	result = []

	for char in text:
		my_list.append(char)

	index = len(my_list)
	while index > 0:
		index = index -1
		result.append(my_list[index])
	
	return "".join(result)