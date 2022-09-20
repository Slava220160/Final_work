# Условия задачи

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*__Примеры:__*

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

## Описание алгоритма решения задачи


1. Вводим строковый массив с клавиатуры
2. Считаем сколько элементов в массиве имеют длину меньше или равную 3. Записываем это значение в переменную.
3. Создаем новый строковый массив с размером, который вычислили на шаге 2.
+ создаем переменную j=0 как счетчик элементов нашего нового строкового массива;
+ в цикле for от 0 до (длинна массива - 1) проверяем длину каждого элемента;
+ если длина элемента удовлетворяет нашим условиям, то записываем этот элемент в элемент нового массива с индексом j и увеличиваем значение j на 1;
+ если длинна элемента не удовлетворяет нашим условиям, то переходим на новый виток цикла;
4. Выводим в консоль наш новый массив

***

### Файл sxema.drawio.png содержит графическое представление алгоритма решения задачи

### Реализация алгоритма по пути Final_work_of_the_1st_quarter/Program.cs
