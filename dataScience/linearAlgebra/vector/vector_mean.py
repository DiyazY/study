from scalar_multiply import scalar_multiply
from vector_sum import vector_sum

def vector_mean(vectors):
    n=len(vectors)
    return scalar_multiply(1/n, vector_sum(vectors))

# vectors = [
#     [1,2,3],
#     [3,2,1],
#     [2,2,3]
# ]

# print(vector_mean(vectors))