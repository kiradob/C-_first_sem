// Задача 62: Заполните спирально массив 4 на 4.


Console.WriteLine("Сейчас произойдет заполнение матрицы по спирали");
Console.WriteLine();
Console.Write("Введите размер массива  m x m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, m];

int number=1;
int i = 0;
int j = 0;

while (number<=m*m)
{
    matrix[i,j]=number;
    if (i<=j+1 && i+j<m-1) 
    ++j;
    else if (i<j && i+j>= m-1) 
    ++i;
    else if (i>=j && i+j>m-1) 
    --j;
    else
        --i;
    ++number;
}
Console.WriteLine();
PrintArray(matrix);

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine();