// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Ввести первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести второе число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)

    {
        if(numberA > numberC)
            {
                  Console.WriteLine($"Число {numberA} больше {numberB} и больше {numberC}");
            }
        else
            {
                Console.WriteLine($"Число {numberC} больше {numberA} и больше {numberB}");
            }
    }
else
{
    if (numberB > numberC)
        {
            Console.WriteLine($"Число {numberB} больше {numberA} и больше {numberC}");
        }
    else
        {
            Console.WriteLine($"Число {numberC} больше {numberA} и больше {numberB}");
        }
    
}