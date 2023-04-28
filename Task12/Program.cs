// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);

Console.WriteLine(remainder !=0 ? $"нет, остаток {remainder}" : "да");

int Remainder(int num1, int num2)
{
    return num1 % num2;
}