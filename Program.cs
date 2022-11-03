// Задача 28. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void PrintMassiv()
{
int[] N = new int[8];
Console.Write("Массив [");
for (int i = 0; i < N.Length; i++)
{
N[i] = new Random().Next(0,99);
Console.Write($"{N[i]} ");
}
Console.Write("]");
}
PrintMassiv();



// Задача 25.  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"результат равен: {Math.Pow(numberA,numberB)}");



Console.Write("Введите число A: ");
int  numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
 int numberB = int.Parse(Console.ReadLine());
 

 int GetCount(int numberA, int numberB){

  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    
    return result;
}
   int  Numbers = GetCount(numberA, numberB);
  Console.WriteLine($"результат равен: {GetCount(numberA, numberB)}");



// Задача 27.  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма цифр = " + GetLength(number));


int GetLength(int number)
{

int sum = 0;
int result = 0;

for(int i = 0; i <= number; i++)
{
    sum = number -  number % 10;
    result = result + (number - sum);
    number = number / 10;
}

return result;

}
int sumN = GetLength(number);


