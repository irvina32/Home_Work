Console.Write("введите первое число: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine ("Первое число больше второго");
}

    else 
    if (n1 < n2)
    {
       
       Console.WriteLine ("Первое число меньше второго"); 
    }
    else
    {
        Console.WriteLine ("Оба числа равны");
    }