// See https://aka.ms/new-console-template for more information


using System;


Console.OutputEncoding = System.Text.Encoding.Unicode;



Console.Write("Введіть число а: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть число b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть число c: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть число d: ");
double d = Convert.ToDouble(Console.ReadLine());


double x = ((a + (2 * b) - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));

double y = (5 * ((a + b) * (c - d))) / (0.5 * c) + (Math.Pow(d, 2) * (((Math.Pow(a, 2)) - Math.Pow(b, 2)) / (b - a)));

double z = ((Math.Pow(Math.Pow(x, 2) - (2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / ((5 * a) + (3 * b));

double r = ((0.5 * a + ((3.0 / 4.0) * b) - (7.0 / 5.0)) / ((3.0 * c) + 1.0)) + (1.0 / (a - c));

Console.WriteLine("Результат: ");

Console.Write($"x = {x}  ");

Console.Write($"y = {y}  ");

Console.Write($"\nz = {z}  ");

Console.Write($"r = {r}  ");

Console.ReadKey();






