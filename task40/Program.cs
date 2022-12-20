// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите последовательно три числа: ");

int A=Convert.ToInt32(Console.ReadLine());
int B=Convert.ToInt32(Console.ReadLine());
int C=Convert.ToInt32(Console.ReadLine());

if (A+B>C && B+C>A && C+A>B)
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник НЕ существует");
}