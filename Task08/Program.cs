// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N/
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Ввидите целое положительное число");
int numbers = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= numbers)
{
    Console.Write($"{count} ");
    count = count + 2;
}
