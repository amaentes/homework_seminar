// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

int a;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)
{
    Console.WriteLine("Число {0} четное", a);
}
else
{
    Console.WriteLine("Число {0} нечетное", a);
}
