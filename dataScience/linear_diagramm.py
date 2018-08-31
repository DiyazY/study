from matplotlib import pyplot as plt

"liner diagramma"
years = [1950, 1960, 1970, 1980, 1990, 2000, 2010]
gdp = [300.2, 543.2, 1075.23, 2758.56, 5978.23, 10289.23, 14958.45]
plt.plot(years, gdp, color='green', marker='o', linestyle='solid')
plt.title('Номинальный ВВП')
plt.ylabel('Млрд $')
plt.show()