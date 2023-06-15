// Задача 56: 
//1 Задайте прямоугольный двумерный массив. 
//2.Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] matrix = CreatMatrixRndInt(4, 4, 1, 4);
PrintMatrix(matrix);

int[] sumMinString = CreateSumMinString(matrix);
Console.WriteLine($"Hомер строки с наименьшей суммой элементов: {MinSumElemNum(sumMinString)} строка");

int MinSumElemNum(int[] array)
{
    int str = 1;
    int sumIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[sumIndex] > array[i]) sumIndex = i;
    }
    return sumIndex + str;
}

int[] CreateSumMinString(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[j, i];
        }
        arr[j] = sum;
    }
    return arr;
}

int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
