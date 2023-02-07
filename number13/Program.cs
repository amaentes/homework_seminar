// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int lenArray = 8;
int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(lenArray);
    Console.Write(randomArray[i] + " ");
}
Console.WriteLine("");

