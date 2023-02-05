// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

long a;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
if (a % 1 == 0 & -100 < a & a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (a <= -100)
{
    string str = Convert.ToString(a);
    Console.WriteLine("Третья цифра числа = {0}", str[3]);
}
else 
{
    string str = Convert.ToString(a);
    Console.WriteLine("Третья цифра числа = {0}", str[2]);
}