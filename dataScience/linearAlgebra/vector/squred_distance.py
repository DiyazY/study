from sum_of_squares import sum_of_squares
from vector_substract import vector_substract
from magnitude import magnitude
import math

def squred_distance(v,w):
    return sum_of_squares(vector_substract(v,w))

# print(squred_distance([1,2,3],[3,2,1]))

# def distance(v,w):
#     return math.sqrt(squred_distance(v,w))

def distance(v,w):
    return magnitude(vector_substract(v,w))

# print(distance([1,2,3],[3,2,1]))