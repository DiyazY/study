def median(v):
	n=len(v)
	sorted_v=sorted(v)
	midpoint=n//2
	
	if n%2==1:
		return sorted_v[midpoint]
	else:
		hi = midpoint
		lo = midpoint - 1
		return (sorted_v[lo]+sorted_v[hi])/2
		
x = [12,23,22,43,57,84,23,11,66,24]

print(median(x))