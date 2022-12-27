// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите размер квадратной матрицы m x m");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,m];
ArrayRandomNumbers(matrix);
PrintArray(matrix);
// Представляет наибольшее возможное значение типа Int32.
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("Cтрока с наименьшей суммой элементов №:" + (indexLine));
Console.WriteLine ("Сумма элементов равна: " + (minsum));

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
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