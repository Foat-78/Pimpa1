// Задача 29: Напишите программу,
//  которая задаёт массив из 8 элементов 
//  и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
//int[] - название типа массива,  array - название массива через знак присваевания создаем новый массив с размером 8
// в массиве находятся нули
//int[] array = new int[8] можно сделать по другому int[] array = new int{1,5,3,7,6,8,9,5}; т.е. сразу можно добавить значение в фигурных скобках
//int[] array = new int[8]можно сделать по другому int[] array = new int[]{1,5,3,7,6,8,9,5}; 
//int[] array = new int[8]можно сделать по другому int[] array = new int[8]{1,5,3,7,6,8,9,5} для улучшения читаемости и избежания ошибок
//int[] array = new int[8] можно сделать по другому var array = new int[8] т.е. var используется когда в правой части обозначение массива int

FillArray(array);
PrintArray(array); 
Console.Write("->");
// FillArray(array);
Console.Write("[");
PrintArray(array); 
Console.Write("]");

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }  
}

void FillArray(int[] array)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,99);
    }
}
