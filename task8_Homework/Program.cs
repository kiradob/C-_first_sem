﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
//все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Ввести натуральное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 1;
if(count==1)
{
    count += 1;
}
while(count<=number)
{
    Console.Write(count+" ");
    count+=2;
}
