// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine ("Введите длину первой стороны: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите длину второй стороны: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите длину третьей стороны: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB + numberC && numberB < numberA + numberC && numberC < numberA + numberB)
{
    Console.WriteLine ("Треугольник со сторонами такой длины может существовать");
}
else
{
Console.WriteLine ("Треугольник со сторонами такой длины не может существовать");
}
