//5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

// Console.Write("Ввести число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i=-N;i<N+1; i++)
// {
//     Console.Write(i);
// }

Console.WriteLine("Ввести число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
while(count<=number)
{
    Console.WriteLine(count);
    count++;
}