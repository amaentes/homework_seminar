// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GetRandomArray(5, -99, 100);
int sum = 0;
Console.WriteLine($"Введен массив {string.Join(", ", array)}");
SumNumbers(array);

int[] GetRandomArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random num = new Random();

    for (int counter = 0; counter < length; counter++)
    {
        array[counter] = num.Next(min, max + 1);
    }
    return array;
}

void SumNumbers(int[] numbers)
{
    Console.Write("");
    for (int i = 0; i < numbers.Length; i+=2)
    {
        sum = sum + numbers[i];
    }
Console.WriteLine($"Всего {numbers.Length} чисел, {sum} это сумма элементов, стоящих на нечетных позициях");
}
