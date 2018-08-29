def dot(v,w):
    """v_1*w_1+...+v_n*w_n"""
    return sum(v_i*w_i for v_i,w_i in zip(v,w))

# print(dot([1,2,3],[3,2,1]))