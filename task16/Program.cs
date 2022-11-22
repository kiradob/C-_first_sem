// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Ввести первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA * numberA == numberB || numberB * numberB == numberA)
{
Console.WriteLine($"Является ли одно из чисел квадратом другого? -> да");
}
else
{
Console.WriteLine($"Является ли одно из чисел квадратом другого? -> нет");
}