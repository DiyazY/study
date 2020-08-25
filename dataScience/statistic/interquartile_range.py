from quantile import quantile as _quantile

def interquartile_range(x):
    return _quantile(x, 0.75) - _quantile(x, 0.25)

print('interquartile_range', interquartile_range([1,2,4,54,34,45]))