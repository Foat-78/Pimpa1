// Задача 68: 
// 1. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// 2. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int ack = Ack(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A({m}, {n}) = {ack}");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ack(m - 1, 1);
    return Ack(m - 1, Ack(m, n - 1));
}