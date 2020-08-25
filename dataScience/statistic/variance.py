from de_mean import de_mean as _de_mean 
import sys
sys.path.insert(1, '../linearAlgebra/vector')
from sum_of_squares import sum_of_squares


def variance(x):
    n=len(x)
    deviations = _de_mean(x)
    return sum_of_squares(deviations) / (n-1)

print('variance', variance([1,2,4,54,34,45]))