// 1. Напишите программу, которая принимает на вход координаты двух точек 
// 2. и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A");
Console.Write("x =  ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("y =  ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("z =  ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("x =  ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("y =  ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("z =  ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int leg1 = x1 - x2;
    int leg2 = y1 - y2;
    int leg3 = z1 - z2;
    double hypo = Math.Sqrt(leg1 * leg1 + leg2 * leg2 + leg3 * leg3);
    return hypo;
}