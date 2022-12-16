/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();
Console.WriteLine("Hello, World!");

// Методы

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] tempArr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = rand.Next(leftRange, rightRange);
    }
    return tempArr;
}
void NAMBERS (out int size, out int leftRange, out int rightRange)
{
    while (true)
    {
        size = CheckInputNumber("Введите размер массива : ");

        if (size < 0) Console.WriteLine("Задано отрицательное значение, попробуйте еще раз.");

        else if (size == 0) Console.WriteLine("Задано нулевое значение, попробуйте еще раз.");

        else break;
    }
    while (true)
    {
       leftRange = CheckInputNumber("Введите величину минимального значения массива : ");

       rightRange = CheckInputNumber("Введите величину максимального значения массива : ");

       if (leftRange <= rightRange) break;
       
    Console.WriteLine("Заданное значение левого края массива больше правого, попробуйте еще раз.");
    } 
}

void SumNumbersOddIndex(int[] arr, out int Summa)
{
    Summa = 0;
    for(int i = 1; i < arr.Length; i += 2)
    {
        Summa += arr[i];
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

int[] arr = FillArrayWithRandomNumbers(size, leftRange, rightRange);

SumNumbersOddIndex(arr, out int Summa);

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("\nОдномерныйный массив заполненный случайными числами :\n\n[" + string.Join(", ", arr) + "]");

Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях в массиве :  {Summa}\n");
Console.ResetColor();
