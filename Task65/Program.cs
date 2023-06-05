// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write("Введите натуральное число M ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);


void NaturalNumbers(int num1, int num2) //0
{   
    if (num1 < num2)
    {
        Console.Write($"{num2} ");
        NaturalNumbers(num1, num2 - 1);
    }
    else if (num1 > num2)
    {
        NaturalNumbers(num1 - 1, num2);
        Console.Write($"{num1} ");
    }
    else
    {
        Console.Write($"{num1} ");     
    }
}