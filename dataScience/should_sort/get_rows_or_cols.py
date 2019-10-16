def get_row(A,i):
	return A[i]

def get_col(A,j):
	return [A_i[j]
				for A_i in A]

A=[
	[1,2,3],
	[3,4,5],
	[4,5,6],
	[6,7,8]
]

print(get_row(A, 3))
print(get_col(A,1))