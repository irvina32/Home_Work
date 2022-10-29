// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

//Console.WriteLine(number);


int firstNumber = 0;
//int secondNumder = 0;


firstNumber = number / 10;

Console.Write(firstNumber % 10);



// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// //Console.WriteLine(n);

// if(n <= 99)
// {   
//     Console.WriteLine("третьей цифры нет");   
// }

//     if (n > 101 && n < 999){

//     Console.WriteLine(n % 10);
// }

// if (n == 100 || n == 1000){

//     Console.WriteLine(n % 10);
// }



//  Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введи цифру дня недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());


// void CheckingTheDayOfTheWeek (int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) 
//   Console.WriteLine("этот день выходной");
  
//   else Console.WriteLine("этот день не выходной");
// }

// CheckingTheDayOfTheWeek(dayNumber);

