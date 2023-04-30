// Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число недели для определения выходного дня");
int number = Convert.ToInt32(Console.ReadLine());

bool result = WallStreet(number);
Console.WriteLine (result ? "да, это выходной" : "нет, не выходной");

bool WallStreet(int num)
{
    return num == 7 || num == 6;
}