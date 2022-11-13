// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.

// Console.WriteLine("enter m: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("enter n: ");
// int n = int.Parse(Console.ReadLine());


// double[,] GetArray(int m, int n)

// {
// double[,] array = new double[m, n];
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = rnd.Next(-10, 10);
// }
// }
// return array;
// }

// void PrintArray(double[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i,j]} ");
// }
// Console.WriteLine();
// }

// }
// Console.WriteLine();
// PrintArray(GetArray(m,n));

//  Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.

// Console.WriteLine("enter m: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("enter n: ");
// int n = int.Parse(Console.ReadLine());


// int[,] GetArray(int m, int n)

// {
// int[,] array = new int[m, n];
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = rnd.Next(1, 10);
// }
// }
// return array;
// }



// Console.WriteLine("enter number: ");

// int number = int.Parse(Console.ReadLine());

// if (array.GetLength(0) < number || array.GetLength(1) < number) Console.WriteLine("такого числа нет");

// else Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");


// void PrintArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i,j]} ");
// }
// Console.WriteLine();
// }

// }
// PrintArray(GetArray(m,n));



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());


int[,] GetArray(int m, int n)

{
 int[,] array = new int[m, n];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(1, 10);
}
}
return array;
}


int GetSumAverage (int[,] array)
{
// int[,] array = new int[m, n];
int sum = 0;
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        double average = 0;
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            average = average + array[i,j];
        }
        average = average / n;
        Console.Write(average + "; ");
    }
}
return sum;
}
Console.WriteLine();

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}

}

int[,] array = GetArray(m,n);
PrintArray(GetArray(m,n));
System.Console.WriteLine();
Console.WriteLine(GetSumAverage(array));

