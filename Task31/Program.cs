// Задача 31:
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9].
// 3. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2-1,8-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max) //создаем массив и задаем размер массива и минимальное, максимальное значение
{
    int[] arr = new int[size]; //Создаем массив целых чисел и передаем размер массива size
    var rnd = new Random();//Cоздаём отдельно экземпляр объекта или экземпляр класса (что бы не выводил одно и то же число) так как если создать в цикле фор то случайное время будет привязано одному и тому же времени
    for (int i = 0; i < arr.Length; i++)//Цикл будет выполняться пока размер массива будет равно счетчику
    {
        arr[i] = rnd.Next(min, max + 1);//Для заполнения массива случайными числами через функцию Next указываем минималное и максимальное число
        //Для того что бы чило максимальное попало в дипозон надо в скобках указать max + 1
    }
    return arr;
}

void PrintArray (int[] arr, string sep)//Вывода массив в консоль и в скобках задаем массив исходный
{
    for (int i = 0; i < arr.Length; i++)//
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

// int[] GetSumPositiveNegativeElem(int[] arr)//Метод для получения положительных и отрицательных чисел
// {
//     int sumPositive = 0;
//     int sumNegative = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0) 
//             sumPositive += arr[i];
//         else 
//             sumNegative += arr[i];
//     }
//     return new int[]{sumPositive, sumNegative};
// }
int GetSumPositiveElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

// int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
// Console.WriteLine($"Cумма положительных элементов равна {sumPositiveNegativeElem[0]}");
// Console.WriteLine($"Cумма отрицательных элементов равна {sumPositiveNegativeElem[1]}");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);
Console.WriteLine($"Cумма положительных элементов равна {sumPositiveElem}");
Console.WriteLine($"Cумма отрицательных элементов равна {sumNegativeElem}");