import math
from variance import variance as _variance

def standard_deviation (x):
    return math.sqrt(_variance(x));

print('standard_deviation', standard_deviation([1,2,4,54,34,45]))