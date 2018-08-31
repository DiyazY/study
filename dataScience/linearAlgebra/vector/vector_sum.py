from vector_add import vector_add
from functools import reduce, partial

# def vector_sum(vectors):
#     result = vectors[0]
#     for vector in vectors[1:]:
#         result = vector_add(result, vector)
#     return result


# vector_sum = partial(reduce, vector_add)

def vector_sum(vectors):
    return reduce(vector_add, vectors)

# vectors = [
#     [1,2,3],
#     [3,2,1],
#     [2,2,3]
# ]

# print(vector_sum(vectors))

