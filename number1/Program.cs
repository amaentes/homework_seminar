// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

int a;
int b;
Console.WriteLine("Введите сначала число а, потом b");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
  Console.WriteLine("Большее число {0}", a);
  Console.WriteLine("Меньшее число {0}", b);
}
else
{
  Console.WriteLine("Большее число {0}", b);
  Console.WriteLine("Меньшее число {0}", a);  
}