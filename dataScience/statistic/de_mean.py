from mean import mean as _mean

def de_mean (x):
    x_bar = _mean(x)
    return [x_i-x_bar for x_i in x]

print('de_mean', de_mean([1,2,4,54,34,45]))