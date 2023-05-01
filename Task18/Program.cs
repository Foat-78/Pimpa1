// 1. Напишите программу, которая по заданному номеру четверти,
// 2.  показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
int numberQuarter = Convert.ToInt32(Console.ReadLine());

string сoordinate = Coordinate (numberQuarter);
string result = сoordinate != "0" ? $"Введенный номер четверти соответствует координатам -> {сoordinate}" : "Введён не корректный номер четверти";
Console.WriteLine(result);

string Coordinate (int num)
{ 
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x > 0, y < 0";
    if (num == 4) return "x < 0, y < 0";
    return "0";
}