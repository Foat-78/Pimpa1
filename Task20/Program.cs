//  Задача по теореме Пифогора
// 1. Напишите программу, которая принимает на вход координаты двух точек
// 2. и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A");
Console.Write("x =  ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("y =  ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("x =  ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("y =  ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA, yA, xB, yB);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2)
{
    int leg1 = x1 - x2;
    int leg2 = y2 - y1;
    double hypo = Math.Sqrt(leg1 * leg1 + leg2 * leg2);
    return hypo;
}