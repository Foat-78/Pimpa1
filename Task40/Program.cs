// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите число А: ");
int sideA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int sideB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C: ");
int sideC = Convert.ToInt32(Console.ReadLine());

bool result = formul(sideA,  sideB, sideC);
Console.WriteLine (result ? $"Да это треугольник!" : "Это не треугольник");

bool formul(int number1, int number2, int number3)
{
    if (number1 + number2 > number3 && number2 + number3 > number1 && number1 + number3 > number2) return true;
    else return false;
    // return number1 + number2 > number3 && number2 + number3 > number1 && number1 + number3 > number2; //Облегчённый вариант решения задачи
}

