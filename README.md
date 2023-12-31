# Итоговая контрольная работа по основному блоку

### Оформленое текстовое описание решения

Мы запрашиваем у пользователя ввод элементов массива через пробел. 
Затем мы разделяем введенную строку на элементы массива и сохраняем их в переменную array. 
Далее мы вызываем метод FilterArray и передаем ему массив array.
Метод FilterArray фильтрует элементы массива и возвращает новый массив, содержащий только элементы, которые удовлетворяют определенному условию. 
После этого мы выводим на экран сообщение "Новый массив:" и вызываем метод PrintArray, чтобы вывести на экран элементы нового массива.

![](/photo_2023-09-26_17-10-59.jpg)



В методе FilterArray происходит фильтрация массива array с использованием метода ElementValid.
Сначала определяется количество элементов в исходном массиве, которые удовлетворяют условию, 
заданному в методе ElementValid. Для этого используется переменная count, которая увеличивается на 1 при каждом элементе, 
который проходит проверку.
Затем создается новый массив result размером count, в котором будут храниться только элементы, прошедшие фильтрацию.
Далее происходит проход по исходному массиву array и для каждого элемента, который проходит проверку в методе ElementValid, 
он добавляется в массив result на соответствующую позицию с помощью переменной index.
Наконец, возвращается массив result, содержащий только элементы, удовлетворяющие условию фильтрации.

![](/photo_2023-09-26_17-25-32.jpg)


Метод ElementValid принимает строку element в качестве параметра и возвращает логическое значение true, 
если длина строки element не превышает 3 символа, и false в противном случае. Данный метод используется для проверки, 
является ли элемент массива допустимым согласно заданным условиям.

![](/photo_2023-09-26_17-09-11.jpg)


Метод PrintArray принимает в качестве параметра массив строк array. 
Затем с помощью цикла for происходит итерация по каждому элементу в массиве. 
На каждой итерации метод выводит текущий элемент на новой строке с помощью Console.WriteLine. 
Это позволяет вывести каждый элемент массива на новой строке в консольном выводе.

![](/photo_2023-09-26_17-37-42.jpg)