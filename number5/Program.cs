// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int a;
Console.WriteLine("Введите трехзначное число");
a = Convert.ToInt32(Console.ReadLine());
if (a < 100 || a >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, запустите программу заново и введите трехзначное число");
}
else if (a >= 100 || a <= 999)
{
    a = a % 100 / 10;
    Console.WriteLine("Вторая цифра числа = {0}", a);
}
