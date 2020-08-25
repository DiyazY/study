from de_mean import de_mean as _de_mean 
import sys
sys.path.insert(1, '../linearAlgebra/vector')
from dot import dot

def covariance(x,y):
    n = len(x)
    return dot(_de_mean(x), _de_mean(y)) / (n-1)

print('covariance', covariance([1,2,4,54,34,45], [2,2,4,5,3,5]))