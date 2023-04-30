// Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

int result = DispleySecondDigit(number);
Console.WriteLine(result);

int DispleySecondDigit (int number)
{
    while (number > 999)
    {
        number /=10;
    }
    return number % 10;
}
