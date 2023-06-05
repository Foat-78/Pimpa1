// Задача 31:
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9].
// 3. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2-1,8-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// Задача 31:
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9].
// 3. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2-1,8-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.(int size, int min, int max)

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
        if (i < array.Length - 1) Console.Write($"{array[i]},{sep}");
        else Console.Write($"{array[i]}");
    }
}

// int[] GetSumPositiveNegotiveElem(int[] array)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0) sumPositive += array[i];
//         else sumNegative += array[i];
//     }
//     return new int[]{sumPositive, sumNegative};
// }

int SumPositive(int[] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) positive += array[i];
    }
    return positive;
}

int[] arr = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(arr, " ");
Console.WriteLine("]");

// int[] sumPositiveNegotiveElem = GetSumPositiveNegotiveElem(arr);
// Console.WriteLine($"положительное {sumPositiveNegotiveElem[0]}");
// Console.Write($"отрицательное {sumPositiveNegotiveElem[1]}");

int sumPositive = SumPositive(arr);
Console.WriteLine($"положительное {sumPositive}");