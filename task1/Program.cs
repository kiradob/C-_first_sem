﻿// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет
Console.Write("Ввести первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberB * numberB == numberA)
{
Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else
{
Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");
}