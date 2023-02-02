//. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//   4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//   2 -> " -2, -1, 0, 1, 2"





Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = (-1) * n;
for (int i = (-1) * n; i <= n; i++)
    Console.Write($"{i} ");
Console.WriteLine();
while (count <= n)
{
    Console.Write($"{count} ");
    count++; // count = count + 1;
}
    
