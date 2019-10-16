def quantile(x,p):
	p_index = int(p*len(x))
	return sorted(x)[p_index]
	
x = [12,23,22,43,57,84,23,11,66,24]

print(quantile(x, 0.1))
print(quantile(x, 0.3))
print(quantile(x, 0.75))
print(quantile(x, 0.93))