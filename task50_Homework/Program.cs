// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите поочередно значения индексов элемента m x n");
Console.Write("Введите номер строки m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца n: ");
int n = Convert.ToInt32(Console.ReadLine());
// Создание матрицы размерностью 5x5
int [,] matrix = new int [5,5];
// Объявление метода ArrayRandomNumbers
ArrayRandomNumbers(matrix);
// Если любое из условий верно, то искомого элемента не существует
if (m > matrix.GetLength(0) || n > matrix.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {m} строки и {n} столбца равно {matrix[m-1,n-1]}");
}

PrintArray(matrix);

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}
// Метод PrintArray - представляет полученную мартицу в терминале
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        } 
        Console.WriteLine(""); 
    }
}