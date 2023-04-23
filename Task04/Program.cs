// Напишите программу, которая на вход принимает три
// числа и выдаёт максимальное из этих чисел.
//Пример:
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22
Console.WriteLine("Ввиди число A!");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввиди число B!");
int numbersB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввиди число C!");
int numbersC = Convert.ToInt32(Console.ReadLine());
int max = numbersA;
if (numbersB > max) max = numbersB;
if (numbersC > max) max = numbersC;
{
    Console.WriteLine($"Максимальное число является {max}!");
}
//Ууууррррраааааа!!!