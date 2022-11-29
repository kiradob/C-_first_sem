// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Exp(int numberA, int numberB)
{
    int result = 1;
    for(int i=1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

  Console.WriteLine("Введите число, которое хотите возвести в степень: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите степень, в которую хотите возвести число: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exp = Exp(numberA, numberB);
  Console.WriteLine($"{numberA} в степени {numberB} = " + exp);