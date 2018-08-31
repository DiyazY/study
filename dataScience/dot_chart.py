from matplotlib import pyplot as plt

friends = [12,34,56,45,67,87,34,56, 90]
minutes =[30,60,123,45,202,230,100,222,300]
labels=['a','b','c','d','e','f','g', 'h', 'i']

plt.scatter(friends,minutes)

for label, friend_count, minute_count in zip(labels,friends,minutes):
    plt.annotate(label,
                 xy=(friend_count,minute_count),
                 xytext=(5,-5),
                 textcoords='offset points')
plt.title('Зависимость между количесвтом минут и числом друзей')
plt.xlabel('Число друзей')
plt.ylabel('Времяб проводимое на сайте ежедневноб мин')
plt.show()