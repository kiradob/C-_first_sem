// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 3);
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

int m = InputInt("Введите размерность матриц: ");
int[,] matrixA = new int[m,m];
int[,] matrixB = new int[m,m];
ArrayRandomNumbers(matrixA);
ArrayRandomNumbers(matrixB);
int[,] matrixC = new int[m,m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < m; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица А:");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица В:");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);