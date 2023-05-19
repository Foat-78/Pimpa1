// 1. Напишите программу, которая на входе принимает два
// числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите значение А");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B");
int numbersB = Convert.ToInt32(Console.ReadLine());
if (numbersA == numbersB * numbersB)
{
    Console.WriteLine($"Да, число {numbersA} является квадратом числа {numbersB} ");
}
else
{
     Console.WriteLine($"Нет, число {numbersA} не является квадратом числа {numbersB} ");
}

