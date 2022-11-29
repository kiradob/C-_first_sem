// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int count=Convert.ToString(number).Length;
    int ch=0;
    int res=0;

    for (int i=0; i<count; i++)
        {
            ch=number-number%10;
            res=res+(number-ch);
            number=number/10;
        }
    return res;
}

int sum = Sum(number);
Console.WriteLine($"Сумма всех цифр в числе {number} = " + sum);
