//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
//все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Ввести натуральное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA % 2 == 0)
{
    Console.WriteLine($"Число {numberA} является четным");
}
else
{
Console.WriteLine($"Число {numberA} НЕ является четным");
}