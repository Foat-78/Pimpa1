// Напишите программу, которая принимает на вход 
// трёхзрачное число и выход показывает последнюю цифру
//этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.WriteLine("Ввидите трёхзначное число!");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0) num *= -1;
if (num >= 100 && num <= 999)
{
    int lastNum = num % 10;
    Console.WriteLine($"Последняя цифра числа {num} => {lastNum}");
}
else Console.WriteLine("Некорректный ввод!");