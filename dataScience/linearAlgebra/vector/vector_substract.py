def vector_substract(v, w):
    return [v_i - w_i
            for v_i, w_i in zip(v,w)]

# v = [1,2]
# w = [2,0]
# print(vector_substract(v,w))