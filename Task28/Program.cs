// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = CountNumbers(number);

Console.WriteLine($"Кол-во цифр в числе {number} =  {count}");


int CountNumbers (int num)
{
    int i = 0;
    while (num != 0) 
    {
        num = num / 10;
        i++;
    }
    return i;
}