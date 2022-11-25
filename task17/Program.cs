// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату X: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int y=Convert.ToInt32(Console.ReadLine());

if(x>0 && y>0)
{
    Console.WriteLine($"При координатах x={x} и y={y} точка находится в I четверти");
}
if(x<0 && y>0)
{
    Console.WriteLine($"При координатах x={x} и y={y} точка находится во II четверти");
}
if(x<0 && y<0)
{
    Console.WriteLine($"При координатах x={x} и y={y} точка находится в III четверти");
}
if(x>0 && y<0)
{
    Console.WriteLine($"При координатах x={x} и y={y} точка находится в IV четверти");
}
else
{
    Console.WriteLine($"Точка с координатами x={x} и y={y} находится на координатной оси");
}