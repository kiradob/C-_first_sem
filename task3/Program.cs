//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

// Console.Write("Ввести порядковый номер дня нелели от 1 до 7, где 1-понедельник: ");
// int today = Convert.ToInt32(Console.ReadLine());
// if(today == 1)
// {
//     Console.WriteLine("Сегодня понедельник");
// }
// if(today == 2)
// {
//     Console.WriteLine("Сегодня вторник");
// }
// if(today == 3)
// {
//     Console.WriteLine("Сегодня среда");
// }
// if(today == 4)
// {
//     Console.WriteLine("Сегодня четверг");
// }
// if(today == 5)
// {
//     Console.WriteLine("Сегодня пятница");
// }
// if(today == 6)
// {
//     Console.WriteLine("Сегодня суббота");
// }
// if(today == 7)
// {
//     Console.WriteLine("Сегодня воскресенье");
// }
// if(today > 7)
// {
//     Console.WriteLine("Не бывает в неделе больше 7 дней, подумай еще раз");
// }
// if(today < 1)
// {
//     Console.WriteLine("Не бывает нулевого или отрицательного дня недели, подумай еще раз");
// }

Console.Write("Ввести порядковый номер дня нелели от 1 до 7, где 1-понедельник: ");
int x = Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 1:
        Console.WriteLine("Сегодня понедельник");
        break;
    case 2:
        Console.WriteLine("Сегодня вторник");
        break;
    case 3:
        Console.WriteLine("Сегодня среда");
        break;
    case 4:
        Console.WriteLine("Сегодня четверг");
        break;
    case 5:
        Console.WriteLine("Сегодня пятница");
        break;
    case 6:
        Console.WriteLine("Сегодня суббота");
        break;
    case 7:
        Console.WriteLine("Сегодня воскресенье");
        break;
    default:
        Console.WriteLine("Нет такого дня недели, подумай еще раз");
        break;
}   