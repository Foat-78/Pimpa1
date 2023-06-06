// Задача 66: 
// 1. Задайте значения M и N.
// 2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int naturalNamberRange = NaturalNamberRange(numberM, numberN);
Console.WriteLine($"{naturalNamberRange}");

int NaturalNamberRange(int numM, int numN)
{
    int sum = 0;
    if (numM > sum) return 0;
     return sum + NaturalNamberRange(numM, numN-1);//5, 4, 3, 2, 1
           
}