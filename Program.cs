// See https://aka.ms/new-console-template for more information
// 

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// Console.WriteLine("Введите натуральное число больше 1:");
// int counter = Math.Abs(Convert.ToInt32(Console.ReadLine())); 
// if (counter == 0) { Console.WriteLine("Вы ввели не натуральное число!");} 
// else
// {
//     void NumberCounter(int counter)
//     {
//         if (counter == 0) return;
//         Console.Write(counter + " ");
//         NumberCounter(counter - 1);
//     }

//     NumberCounter(counter);
// }



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Введите начальное целое число M нижнего дипазона значений: ");
// int M = Convert.ToInt32(Console.ReadLine());

// if (M < 1) M = 1;

// Console.Write("Введите конечное целое число N верхнего дипазона значений: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (N < 1)
// {
//     Console.Write("В заданном Вами диапазоне отсутствуют натуральные числа");
// }
// else
// {

//     SumFromMToN(M, N);

  
//     void SumFromMToN(int m, int n)
//     {
//         Console.Write("Сумма натуральных чисел в заданном диапазоне: " + SumMN(M - 1, N));
//     }

   
//     int SumMN(int M, int N)
//     {
//         int result = M;
//         if (M == N)
//             return 0;
//         else
//         {
//             M++;
//             result = M + SumMN(M, N);
//             return result;
//         }
//     }
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.Write("Введите число N: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akk(m, n)); 
}

// функция Аккермана
int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return (Akk(m - 1, Akk(m, n - 1)));
    }
}