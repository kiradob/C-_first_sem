// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Одномерный массив — это фиксированное количество элементов одного и того же типа, 
// объединенных одним именем, где каждый элемент имеет свой номер. 
// Обращение к элементам массива осуществляется с помощью указания имени массива и номеров элементов.

Console.Write("Введите длину массива: ");
int size=Convert.ToInt32(Console.ReadLine());
int[] array=new int[size];
FillArrayRandomNumbers(array);
Console.Write("Массив: ");
PrintArray(array);
int sum=0;

for (int i=0; i<array.Length; i+=2)
    sum=sum+array[i];

    Console.WriteLine($"В массиве {array.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] array)
{
    for(int y=0; y<array.Length; y++)
        {
            array[y] = new Random().Next(1,10);
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