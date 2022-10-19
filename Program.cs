//Console.WriteLine("Введите число: , , ");

int a=1;
int b=3;
int c=7;

int max = a;


//int numA = int.Parse(Console.ReadLine());

if (a > b) max = a;

else
{
    if (b > a) max = b;
}

if (a > c) max = a;

else
{
    if (c > a) max = c;
}

Console.Write("max= ");
Console.WriteLine(max);
