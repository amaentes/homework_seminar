// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int max;
int b;
int a;
int c;
Console.WriteLine("Введите три числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
  max = a;
}
else
  if(b > c)
  {
    max = b; 
  }
  else
    {
      Console.WriteLine("Большее число {0}", max);
    }
