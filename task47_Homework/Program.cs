﻿// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
// Матрица с вещественными числами
double [,] matrix = new double [m,n];
// Объявление методов
ArrayRandomNumbers(matrix);
PrintArray(matrix);

// Метод ArrayRandomNumbers - заполняет матрицу вещественными числами (цикл в цикле)
void ArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000)/10);
        }
    }
}
// Метод PrintArray - представляет полученную мартицу в терминале
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}