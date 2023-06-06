// Задача 64: 
// 1. Задайте значение N. 
// 2. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// 3.Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {number} -> ");
NaturalNumber(number, ",");

void NaturalNumber(int num, string sep)
{
   if(num < 0) Console.Write($"Ошибка - введите натуральное число");
   else
   {
     if (num == 0) return;
    Console.Write($"{num}{sep} ");
    NaturalNumber(num - 1, sep);
   }
}
    
   