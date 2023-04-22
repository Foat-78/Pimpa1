// 1. Напишите программу, которая на входе принимает два
// числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите значение А");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B");
int numbersB = Convert.ToInt32(Console.ReadLine());
if (numbersA == numbersB * numbersB)
{
    Console.WriteLine("$Да, число {numberA} является квадратом числа {numberB} ");
}
else
{
     Console.WriteLine("$Нет, число {numberA} не является квадратом числа {numberB} ");
}
    