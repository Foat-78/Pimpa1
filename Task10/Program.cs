// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = DispleySecondDigit(number);
Console.WriteLine(result);
int DispleySecondDigit (int num)
{
    int firstDigit = num / 10;
    int thirdDigit = firstDigit % 10;
    return thirdDigit;
}