// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1 из уравнения y = k1 * x + b1");

// Геометрический смысл коэффициента b – длина отрезка, который отсекает прямая по оси Oy, 
// считая от начала координат.
// Геометрический смысл коэффициента k – угол наклона прямой к положительному направлению оси Ox, 
// считается против часовой стрелки.

double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1 из уравнения y = k1 * x + b1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2 из уравнения y = k2 * x + b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2 из уравнения y = k2 * x + b2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Описанные прямые пересекутся в точке с координатами X: {x}, Y: {y}");