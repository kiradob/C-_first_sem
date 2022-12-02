// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Write("Введите длину массива: ");
int size=Convert.ToInt32(Console.ReadLine());
double[] array=new double[size];
FillArrayRandomNumbers(array);
Console.Write("Массив: ");
PrintArray(array);
double min=Int32.MaxValue;
double max=Int32.MinValue;

for (int i=0; i<array.Length; i++)
{
    if (array[i]>max)
        {
            max=array[i];
        }
    if (array[i]<min)
        {
            min=array[i];
        }
}

Console.WriteLine($"В массиве {array.Length} чисел. Max значение = {max}, min значение = {min}");
Console.WriteLine($"Разница между max и min значениями = {max - min}");

void FillArrayRandomNumbers(double[] array)
{
    for(int y=0; y<array.Length; y++)
        {
            array[y]=Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int y=0; y<array.Length; y++)
        {
            Console.Write(array[y] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}