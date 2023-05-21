// Задача 25: Напишите цикл,
//  который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiationNumber = ExponentiationNumber(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {exponentiationNumber}");

int ExponentiationNumber(int numA, int numB)
{
    int num = 1;
    int i = 0;
    while (i < numB)
    {
        num = num * numA;
        i++;
    }
    return num;
}

