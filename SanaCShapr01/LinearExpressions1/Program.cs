using System;

double a, b, c, d, x, y, z, r;

Console.WriteLine("Enter number a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number c: ");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number d: ");
d = Convert.ToDouble(Console.ReadLine());

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (Math.Pow(a, 2)) / (Math.Pow(b, 2));
Console.WriteLine($"x = {x}");


y = (5.0 * (a + b) * (c - d)) / ((1.0 / 2.0) * c) + (Math.Pow(d, 2)) * ((Math.Pow(a, 2) - Math.Pow(b, 2))) / (b - a);
Console.WriteLine($"y = {y}");


z = ((Math.Pow(Math.Pow(x, 2) - 2 * x, 3)) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine($"z = {z}");


r = (((1.0 / 2.0) * a) + ((3.0 / 4.0) * b) - (7.0 / 5.0)) / (3 * c + 1) + (1.0 / a - c);
Console.WriteLine($"r = {r}");