// Задача 19: Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите число, состоящее из 5-и знаков: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
if(number[0]==number[4] && number[1]==number[3])
    {
        Console.WriteLine($"Введенное число {number} является палиндромом.");
    }
else Console.WriteLine($"Введенное число {number} НЕ является палиндромом.");
}

if (number.Length == 5)
{
  CheckingNumber(number);
}
else 
{
    Console.WriteLine("Введите число, состоящее из 5-и знаков");
}