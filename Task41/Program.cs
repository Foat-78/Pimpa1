// Задача 41: 
// 1.Пользователь вводит с клавиатуры M чисел. 
// 2.Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] fillArray = FillArray(number);
Console.Write(fillArray);

PrintArray(fillArray);

int sumPositiveNum = SumPositiveNum(fillArray);
Console.Write(sumPositiveNum);

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число М: ");
        arr[i] = Convert.ToInt16(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} - > ");
    }
}

int SumPositiveNum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0) sum++;
    }
    return sum;
}



