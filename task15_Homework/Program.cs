// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Ввести порядковый номер дня нелели от 1 до 7, где 1-понедельник: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day == 6 || day == 7) 
{
  Console.WriteLine($"Является ли {day} день выходным днем? -> да, можно отдыхать");
}
else if(day<1 || day>7)
{
  Console.WriteLine("Нет такого дня недели, подумай еще раз");
}
else 
{
  Console.WriteLine($"Является ли {day} день выходным днем? -> нет, пора на работу");
}
