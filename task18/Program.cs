// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

// Вариант 1
// Console.WriteLine("Введите номер четверти от 1 до 4: ");
// int qnumber=Convert.ToInt32(Console.ReadLine());


// if(qnumber==1)
// {
//     Console.WriteLine("Возможный диапазон координат x>0 и y=>0");
// }
// else if(qnumber==2)
// {
//     Console.WriteLine("Возможный диапазон координат x=<0 и y>0");
// }
// else if(qnumber==3)
// {
//     Console.WriteLine("Возможный диапазон координат x<0 и y<0");
// }
// else if(qnumber==4)
// {
//     Console.WriteLine("Возможный диапазон координат x>0 и y<0");
// }
// else
// {
//     Console.WriteLine("Точка лежит на оси");
// }

// Вариант 2

string [] quarters = {"x > 0; y > 0",// 0
                        "x < 0; y > 0",// 1
                        "x < 0; y < 0",// 2
                        "x > 0; y < 0"// 3
};
Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if(quarter >= 1 && quarter <= 4)
{
Console.WriteLine(quarters[quarter-1]);
}
else
{
Console.WriteLine("Такой четверти нет");
}