// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее
// и какое число меньшее?
//Например: 
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3
Console.WriteLine("Ввиди число a!");
int numbersa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввиди число b!");
int numbersb = Convert.ToInt32(Console.ReadLine());
int max = numbersa;
int min = numbersa;
if (numbersb > max) max = numbersb; Console.WriteLine($"Максимальное число является {max}!");
if (numbersb < min) min = numbersb; Console.WriteLine($"Минимальное число является {min}!");
//Ууууурррррааааааааааааааа!