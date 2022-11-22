//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру 
//этого числа.  
// 456 -> 6  
// 782 -> 2  
// 918 -> 8


Console.Write("Ввести трёхзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number<100 || number>999)
{
    Console.Write($"{number} не трёхзначное число");
}
else
{
    Console.WriteLine(number%10);
}

