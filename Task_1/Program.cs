/*
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();
Console.WriteLine("Hello, World!");

// Методы

int[] FillArrayWithRandomNumbers(int leftRange, int rightRange)
{
    int size;

    while (true)
    {
        size = CheckInputNumber("\nВведите размер массива : ");
        if (size < 0)
        { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Задано отрицательное значение, попробуйте еще раз.");
            Console.ResetColor();
        }
        else if (size == 0)
        { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Задано нулевое значение, попробуйте еще раз.");
            Console.ResetColor();
        }
        else 
            break;
    }
    
    int[] tempArr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArr;
}

void CountEvenNumbers(int[] arr, out int count)
{
    count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) count++;
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
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Заданное значение числа не соответствует критерию, попробуйте еще раз.");
        Console.ResetColor();
    }
    Console.ResetColor();
    return number;
}

// Код решения

const int Left_Range = 99;
const int Right_Range = 999;

int[] arr = FillArrayWithRandomNumbers(Left_Range, Right_Range);

CountEvenNumbers(arr, out int count);

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("\nМассив заполненный случайными положительными трёхзначными числами :\n\n[" + string.Join(", ", arr) + "]");

Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine($"\nКоличество чётных чисел в массиве :  {count}\n");
Console.ResetColor();
