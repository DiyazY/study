def shape(A):
	num_rows = len(A)
	num_cols=len(A[0]) if A else 0
	return num_rows, num_cols
	
A=[
	[1,2,3],
	[3,4,5],
	[4,5,6],
	[6,7,8]
]

print(shape(A))
	