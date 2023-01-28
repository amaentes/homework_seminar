// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int max;
int b;
int a;
int c;
Console.WriteLine("Введите три числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    max = a;
}
else if (b > c && b > a)
{
    max = b;
}
else if (c > a && c > b)
{
    max = c;
    Console.WriteLine("Большее число {0}", max);
}
else
{
    Console.WriteLine("Числа равны между собой");
}


