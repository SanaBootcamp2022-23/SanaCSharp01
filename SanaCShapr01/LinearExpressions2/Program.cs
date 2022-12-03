using System;

double a, b, z1, z2, m, n, y, x;

Console.WriteLine("Enter number m: ");
m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number n: ");
n = Convert.ToDouble(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n) / m);
Console.WriteLine($"z1 = {z1}");
Console.WriteLine($"z2 = {z2}");


Console.WriteLine("Enter number x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number b: ");
b = Convert.ToDouble(Console.ReadLine());

y = (2.4 * Math.Abs((x * x + b) / a)) + ((a - b) * Math.Pow(Math.Sin(a - b), 2)) + (Math.Pow(10, -2) * (x - b));
Console.WriteLine($"y = {y}");