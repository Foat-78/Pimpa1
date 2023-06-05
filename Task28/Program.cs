// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0) Console.WriteLine("Введено не натуральное число!!!");
else
{
int produktNumber = ProduktNumber(number);
Console.WriteLine($"Кол-во цифр в числе {number} =  {produktNumber}");
}
// int ProduktNumber (int num)
// {
//     int count = 1;
//     int  i = 1;
//     while (i <= num) 
//     {
//         count *= i;
//         i++;
//     }
//     return count;
// }
//1*1=1
//1*2=2
//2*3=6
//6*4=24

int ProduktNumber (int num)
{
    int count = 1;
    for (int i = 1; i <= num; i++)
    {
        checked //оператор который проверяет на переполнение чисел в ToInt32 и выдаёт ошибку
        {
        count *= i;
        }
    }
    return count;
}