from standard_deviation import standard_deviation
from covariance import covariance

def correlation(x,y):
    stdev_x = standard_deviation(x)
    stdev_y = standard_deviation(y)
    if stdev_x > 0 and stdev_y>0:
        return covariance(x,y)/stdev_x/stdev_y
    else:
        return 0
    
print('correlation', correlation([11,2,4,54,34,45], [1,2,4,5,3,5]))