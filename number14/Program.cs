// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetRandomArray(8, 100, 1000);
int count = 0;
Console.WriteLine($"Введен массив {string.Join(", ", array)}");
QuantityNumber2(array);

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

void QuantityNumber2(int[] numbers)
{
    Console.Write("");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        count++;
    }
Console.WriteLine($"Всего {numbers.Length} чисел, {count} из них четные");
}
