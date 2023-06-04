// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                     //   0      1    
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = arr.GetLength(1)
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
            Console.Write($"{matrix[i, j],1} ");
        }
        Console.WriteLine();
    }
}

void PrintElementArray(int[,] matrix, int rows, int columns)
{
    // if (rows > -1 && columns > -1)
    // {
        if (rows + 1 > matrix.GetLength(0) && columns + 1 > matrix.GetLength(1)) Console.Write($"{rows},{columns} -> такого элемента в массиве нет");
        else Console.Write($"{rows}, {columns} -> {matrix[rows, columns]}");
    // }
    //  Console.Write($"{rows}, {columns} -> вы ввели отрицательное число");
}


int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);

Console.Write("Введите элемент массива строки: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент массива столбца: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
PrintElementArray(array2d, rows1, columns1);
