// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("введите число N: ");
int x;
int n = Convert.ToInt32(Console.ReadLine()), count = (-1) * n;
for (int i = (-1) * n; i <= n; i++)
    Console.Write($"{i} ");
Console.WriteLine();
x = (n % 2);
if (x < 1)
{while (count <= n)
{
 
    Console.Write($"{count} ");
    count++; // count = count + 1;
}}


