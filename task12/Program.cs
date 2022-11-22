// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Ввести первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA%numberB == 0)
{
    Console.WriteLine($"Число {numberA} кратно {numberB}");
}
else
{
    int ostatok=numberA%numberB;
    Console.WriteLine($"остаток деления числа {numberA} на число {numberB} равен {ostatok}");
}