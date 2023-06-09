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

bool result = Side(sideA, sideB, sideC);
Console.WriteLine(result ? $"Треугольник" : "нет");

bool Side(int A, int B, int C)
{
    if (A < B + C && B < C + A && C < A + B) return true;
    else return false;
}