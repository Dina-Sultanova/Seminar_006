// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int [] RandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int [size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}
int[] sourceArray = RandomArray(12, -10, 10);
Console.WriteLine($"Исходный массив {string.Join(", ", sourceArray)}");

int[] copiedArray = sourceArray;
Console.WriteLine($"Скопированный массив {string.Join(", ", sourceArray)}");