// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void ReserveArray(int[] array)
{
    for (int i = 0; i < array.Length /2; i++)
    {
        int temp = array[i];
        array[i] = array [array.Length - 1 - i];
        array [array.Length - 1 - i] = temp;

    }
}
Console.WriteLine ("Введите число: ");
int numberTen = int.Parse(Console.ReadLine()!);
int size = (int)Math.Log2(numberTen) + 1;
int [] array = new int[size];


for (int i = 0; i < array.Length; i++)
{
    array[i] = numberTen % 2;
    numberTen = numberTen / 2;
}

ReserveArray(array);
Console.WriteLine(string.Join("", array));