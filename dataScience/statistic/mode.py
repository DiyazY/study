from collections import Counter

def mode(x):
	counts=Counter(x)
	max_count = max(counts.values())
	return [x_i for x_i, count in counts.items() if count == max_count]
	
x = [12,23,22,43,57,84,23,11,66,24]

print(mode(x))