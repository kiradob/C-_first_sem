﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputInt("Введите натуральное число M (m<n): ");
int n = InputInt("Введите натуральное число N (m<n): ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountSum(int m, int n)
{
    if (m==n)
        return n;
    return n+CountSum(m,n-1);
}