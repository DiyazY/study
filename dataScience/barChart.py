from matplotlib import pyplot as plt

"bar charts"
movies = ["Энни Холл", "Бен-Гур", "Касабланка", "Ганди", "Вестсайдская история"]
num_oscars = [5, 11, 3, 8, 10]
xs = [i + 0.1 for i, _ in enumerate(movies)]
plt.bar(xs, num_oscars)
plt.ylabel("Кол-во наград")
plt.title("Мои любимые фильмы")
plt.xticks([i + 0.1 for i,_ in enumerate(movies)], movies)
plt.show()