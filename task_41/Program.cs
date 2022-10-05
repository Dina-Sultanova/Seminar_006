// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите числа через пробел ");
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int positive = 0;

for (int k = 0; k < array.Length; k++)
{
    if (array[k] > 0)
    {
       positive = positive + 1; 
    }
}

Console.WriteLine($"Количество чисел больше нуля {positive}");