﻿double a, b, c, d;
Console.WriteLine("please input: a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("please input: b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("please input: c");
c = double.Parse(Console.ReadLine());
Console.WriteLine("please input: d");
d = double.Parse(Console.ReadLine());
double x;
double y;
double z;
double r;

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
y = ((5 * (a + b) * (c - d)) / (0.5 * c)) + (d * d * (a * a - b * b)) / (b - a);
z = ((x * x - 2 * x) * (x * x - 2 * x) * (x * x - 2 * x) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
r = (1 / 2.0 * a + 3 / 4.0 * b - 7 / 5.0) / (3 * c + 1) + (1 / (a - c));
Console.WriteLine("result \n");
Console.WriteLine($"x is : {x}\n");
Console.WriteLine($"y is : {y}\n");
Console.WriteLine($"z is : {z}\n");
Console.WriteLine($"r is : {r}\n");