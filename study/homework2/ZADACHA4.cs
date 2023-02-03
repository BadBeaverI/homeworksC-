//.Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Clear();

int i = 0;
Console.Write("Введите 3 числа: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int o = Convert.ToInt32(Console.ReadLine());
if         (n > m)
{    i = (n); }
    else 
    {i = (m);}
if (o > i) {i = (o);
Console.Write("максимальное значение: ");
Console.Write (i);}
    else {Console.Write("максимальное значение: ");
Console.Write (i);}