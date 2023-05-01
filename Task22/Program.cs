// 1. Напишите программу, которая принимает на вход число (N)
// 2. и выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите число N = ");
int numberN = Convert.ToInt32(Console.ReadLine());

Square(numberN);

void Square(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($" Квадрат числа {count} ->  {count*count}");
        count++;
    }
}