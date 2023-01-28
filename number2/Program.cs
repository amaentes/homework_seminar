// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int b;
int a;
int c;
Console.WriteLine("Введите три числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
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
}
else
{
    Console.WriteLine("Числа равны между собой");
}
Console.WriteLine("Большее число {0}", max);