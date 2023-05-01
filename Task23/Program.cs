// 1. Напишите программу, которая принимает на вход число (N)
// 2. и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число N = ");
int numberN = Convert.ToInt32(Console.ReadLine());

Square(numberN);

void Square(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($" Куб числа {count} ->  {count*count*count}");
        count++;
    }
}