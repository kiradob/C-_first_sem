// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Write("Введите длину массива: ");
int size=Convert.ToInt32(Console.ReadLine());
int[] array=new int[size];
FillArrayRandomNumbers(array);
Console.Write("Массив: ");
PrintArray(array);
int count=0;

for (int i=0; i<array.Length; i++)
if (array[i]%2==0)
count++;

Console.WriteLine($"В массиве {array.Length} цифр, из них {count} чётные");

void FillArrayRandomNumbers(int[] array)
{
    for(int y=0; y<array.Length; y++)
    {
        array[y]=new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int y=0; y<array.Length; y++)
    {
        Console.Write(array[y] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}