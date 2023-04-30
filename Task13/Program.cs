// Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

int result1 = DispleySecondDigit(number);
bool result2 = ValidateNumber(number);
Console.WriteLine(result1 < 10 ? result1 : result2);

int DispleySecondDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num = num % 10;
}
bool ValidateNumber(int num)
{
    if (num < 100)
    {
        Console.Write("Третьей цифры нет ");
        return false;
    }
    return true;
}