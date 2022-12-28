// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

int m = InputInt("Введите натуральное число m (m<n): ");
int n = InputInt("Введите натуральное число n (m<n): ");

if (m<1)
{
    Console.WriteLine("Ввели не положительное число");
}
if (n<1)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(NaturalNumber(n, m));


int NaturalNumber(int m, int n)
{
    if (m == n)
        return m;
    else
        Console.Write($"{NaturalNumber(m, n+1)}, ");
    return n;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}