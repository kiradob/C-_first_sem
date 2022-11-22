//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру 
//этого числа.  456 -> 6  782 -> 2  918 -> 8


Console.Write("Ввести трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (-99<number<100)
{
    Console.Write($"{number} не трёхзначное число");
}
if (number>999)
{
    Console.Write($"{number} не трёхзначное число");
}
if (number>-999)
{
    Console.Write($"{number} не трёхзначное число");
}
number=number%10;
