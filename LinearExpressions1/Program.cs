﻿double a, b, c, d, x, y, z1, z2, z3, r, r2;

a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
d = double.Parse(Console.ReadLine());
Console.WriteLine("x = {0}", x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2)));
Console.WriteLine("y = {0}", y = (((5 * (a + b) * (c - d)) / (0.5 * c)) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a))));
z1 = Math.Pow((Math.Pow(x, 2) - 2 * x), 3);
z2 = -4 * (Math.Pow(x, 4) + 1);
z3 = z1 + z2;
z1 = z3 * (1 - b);
z2 = 5 * a + 3 * b;
z1 = z1 / z2;
Console.WriteLine("z = {0}", z1);
r = (((1 / 2.0) * a + (3 / 4.0) * b - (7 / 5.0)) / (3 * c + 1));
r2 = (1 / (a - c));
r = r + r2;
Console.WriteLine("r = {0}", r);