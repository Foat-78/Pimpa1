﻿// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] arr = new int[8]; //Задаем тип массива с названием и присваиваем ему размер значении

// FillArray(arr);
// Console.Write("[");
// PrintArray(arr); 
// Console.Write("]");

// void PrintArray(int[] array)//Функция для вывода массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, "); //Если i < array.Length - 1 выводит значение с запятой
//         else Console.Write($"{array[i]}");//Иначе выводить просто значение
//     } 
// }

// void FillArray(int[] array)//Функция для заполнения массива
// {
//     var rnd = new Random();//
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = rnd.Next(0, 2);//Прохождение по циклу и присвайвание псевдослучайное число Next привязано к системному времени компа и если new Random()
//         // применить внутри цикла for то случайное число на выводе будет повторятса если не пройдет 15 милисекунд и по этому необходимо его применять
//        //перед циклом for как указано в 23 строке
//     }
// }


int[] newArr = CreateArray(11);
Console.Write("[");
PrintArray(newArr);
Console.Write("]");

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}

int[] CreateArray(int size)//Вместо 6  строкии  и функции FillArray(arr) можно создать функцию CreateArray с указанием названия размера size
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}