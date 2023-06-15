// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] firstMatrix = CreatMatrixRndInt(2, 2, 1, 10);
int[,] secondMatrix = CreatMatrixRndInt(2, 2, 1, 10);
Console.WriteLine("Первая матрица: ");
PrintMatrix(firstMatrix);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);

int[,] mulptiplicationMatrix = MulptiplicationMatrix(firstMatrix, secondMatrix);
Console.WriteLine($"Произведение двух матриц:");
PrintMatrix(mulptiplicationMatrix);

int[,] MulptiplicationMatrix(int[,] first, int[,] second)
{
    int[,] multMatrix = new int[first.GetLength(0), second.GetLength(1)];
    int mult = 1;
    int sum = 0;
    for (int i = 0; i < multMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < second.GetLength(0); k++)
            {
                mult *= first[i, k] * second[k, j];
                sum += mult;
                mult = 1;
            }
            multMatrix[i, j] = sum;
            sum = 0;
        }
    }
    return multMatrix;
}

int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}






