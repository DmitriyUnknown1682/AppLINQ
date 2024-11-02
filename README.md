Задача Nº1. (LINQ)
Написать функцию sumintervals которая принимает массив интервалов и возвращает сумму длин всех интервалов. Пересекающиеся интервалы должны быть посчитаны только один раз.
Алгоритм должен работать с большими интервалами диапазон [-1000000000, 1000000000].
Интервалы представлены как пара целочисленных значений в виде массива. Первый параметр интервала всегда меньше второго. Пример интервала [1, 5] длина интервала 4.
Список пересекающихся интервалов:
[[1, 4], [7, 101, [3, 51]
Сумма длин этих интервалов - 7. Так как [1, 4] и [3, 5] пересекаются, и должны считаться как единый интервал [1, 5], длина которого равна 4.
Примеры:
sumIntervals([[1, 2], [6, 10], [11, 15]]) => 9
sumintervals(I[1, 4], [7, 10], [3, 5]]) => 7
sumIntervals(I[1, 5], [10, 20], [1, 6], [16, 191, [5, 11]]) => 19
sumintervals (lO, 20], -100000000, 10], [30, 40]]) => 100000030
