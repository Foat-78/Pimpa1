﻿// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(numbers);
Console.WriteLine($"Сумма цифр {numbers} -> {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10; //эквивалент sum += num % 10;
        num = num / 10;
    }
    return sum;
}
