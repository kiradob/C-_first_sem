// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Ввести трёхзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string numberText = Convert.ToString(number);
Console.WriteLine($"вторая цифра числа {number} -> " + numberText[1]);

