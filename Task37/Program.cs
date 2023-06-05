// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array, string sep)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}{sep} ");
        else Console.Write($"{array[i]}");
    }
}

int[] MultiplicationPairNums(int[] array)
{
    int size = array.Length / 2; //создаем переменную size и присваиваем исходный размер массива для подсчета с четным количеством элемента в массиве т.е. размер массива делим на попалам
    if (array.Length % 2 == 1) size += 1;//если длина массива остатком деления на 2 будет равно 1 то мы на размер массива присвеваем 1
    int[] newArr = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArr[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) newArr[size - 1] = array[array.Length / 2];//строка вывода нечетного элемента в массиве когда массив состоит из нечетного количества элементов Например из 5, 7, 9, 11, и тд
    return newArr;
}


int[] array = CreateArrayRndInt(5, 1, 10);

Console.Write("[");
PrintArray(array, ",");
Console.Write("] -> ");

int[] resArr = MultiplicationPairNums(array);

PrintArray(resArr, ",");