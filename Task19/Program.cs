// 1. Напишите программу, которая принимает на вход пятизначное число и
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Palindrome(number);

if (number < 10000 || number >= 100000 && number < -10000 || number >= 100000)
{
    Console.Write("Ошибка - введите пятизначное число и повторите операцию!");

}
else if (result == true)
{
    Console.WriteLine($"{number} -> да, является палиндромом");
}
else
{
    Console.WriteLine($"{number} -> нет, не является палиндромом");
}

bool Palindrome(int num)
{
    int firstDigit = num / 10000;
    int fifthDigit = num % 10;
    int secondDigit = num / 1000 % 10;
    int fourthDigit = num / 10 % 10;
    int digits = firstDigit / fifthDigit * secondDigit / fourthDigit;
    return digits == 1;
}
