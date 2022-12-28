// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int count=0;
// void Numbers (int num)
// {
//     if (num==0)
//     {
//         return;
//     }
//     count++;
//     Console.Write($"{count} ");
//     Numbers(num-1);
// }
// Console.Write("Введите число: ");
// int nums=int.Parse(Console.ReadLine());
// Numbers(nums);

int count=0;
void Numbers (int num)
{
    if (num==0)
    {
        return;
    }
    Numbers(num-1);
    Console.Write($"{num} ");
}
Console.Write("Введите число: ");
int nums=int.Parse(Console.ReadLine());
Numbers(nums);