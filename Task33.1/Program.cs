// Задача 33:
// 1. Задайте массив. 
// 2. Напишите программу, которая определяет элементы, 
// присутствует ли заданное число в массиве.
// 4; массив [6,7,19,345,3]->нет
// 3; массив [6,7,19,345,3]->да

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
        if (i < array.Length - 1) Console.Write($"{array[i]}{sep}");
        else Console.Write($"{array[i]}");
    }
}

bool NumberElem(int[] array, int num)
{
    num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}



int[] arr = CreateArrayRndInt(10, -6, 6);
PrintArray(arr,", ");
Console.WriteLine();
Console.WriteLine("Введите число для определения в массиве");
int number = Convert.ToInt32(Console.ReadLine());

bool numberElem = NumberElem(arr, number);
Console.WriteLine(numberElem ? "число в массиве нет" : "Число в массиве есть");

