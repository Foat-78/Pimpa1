// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array, string sep)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}{sep} ");
        else Console.Write($"{array[i]}");
    }
}

int[] MultiplicationNums(int[] array)
{
   int size = array.Length / 2;
   if (array.Length % 2 == 1) size += 1;
   int[] arr2 = new int[size];
   for (int i = 0; i < array.Length / 2; i++)
   {
    arr2[i] = array[i] * array[array.Length - 1 - i];
   }
   if (array.Length % 2 == 1) arr2[size - 1] = array[array.Length/2];
   return arr2;
}



int[] array = CreateArrayRndInt(5, 1, 99);
Console.Write("[");
PrintArray(array, ",");
Console.Write("] -> ");

int[] resArr = MultiplicationNums(array);
Console.Write("[");
PrintArray(resArr, " ");
Console.Write("]");