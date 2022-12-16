/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();
Console.WriteLine("Hello, World!");

// Методы

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] tempArr = new double[size];
    Random rand = new Random();
    for(int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = rand.Next(leftRange, rightRange) + Math.Round(Math.Abs(rand.NextDouble()), 3);
    }
    return tempArr;
}

void NAMBERS (out int size, out int leftRange, out int rightRange)
{
    while (true)
    {
        size = CheckInputNumber("Введите размер массива от двух элементов : ");

        if (size < 0) Console.WriteLine("Задано отрицательное значение, попробуйте еще раз.");
        
        else if (size == 0) Console.WriteLine("Задано нулевое значение, попробуйте еще раз.");

        else if (size == 1) Console.WriteLine("Задан массив с одним элементом, попробуйте еще раз.");
        
        else break;
    }
    while (true)
    {
       leftRange = CheckInputNumber("Введите величину левого значения массива : ");

       rightRange = CheckInputNumber("Введите величину правого значения массива : ");

       if (leftRange <= rightRange) break;

    Console.WriteLine("Заданное значение левого края массива больше правого, попробуйте еще раз.");
    } 
}

void MinMaxNamber(double[] arr, out double min, out double max)
{
    min = arr[0];
    max = arr[0];

    for(int i=1; i < arr.Length; i++) 
    {      
    min = Math.Min(arr[i], min);
    max = Math.Max(arr[i], max);
    }
}

int CheckInputNumber(string Text)
{
    Console.ForegroundColor = ConsoleColor.Yellow;

    int number;
    string text;
    
    while (true)
    {
        Console.Write(Text);
        text = Console.ReadLine();

        if (int.TryParse(text, out number)) break;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Заданное значение числа не соответствует критерию, попробуйте еще раз.");
        Console.ResetColor();
    }
    Console.ResetColor();
    return number;
}

// Код решения

NAMBERS (out int size, out int leftRange, out int rightRange);

double[] arr = FillArrayWithRandomNumbers(size, leftRange, rightRange);

MinMaxNamber(arr, out double min, out double max);

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine($"\nОдномерныйный массив заполненный случайными вещественными числами от {leftRange} до {rightRange} :\n\n[ " + string.Join("; ", arr) + " ]");

Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine($"\nРазность между максимальным {max} и минимальным {min} элементами массива равна :  {max - min}\n");
Console.ResetColor();





   
