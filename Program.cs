﻿Console.Clear();
Console.WriteLine("Введите X1 ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите X2 ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1 ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y2 ");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Z1 ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Z2 ");
double z2 = double.Parse(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - Y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"d = {d:f4}");