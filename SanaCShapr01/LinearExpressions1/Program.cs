using System;
using static System.Math;
double a, b, c, d, x, y, z, r;


Console.WriteLine("Enter a:");
a= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter c:");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter d:");
d = Convert.ToDouble(Console.ReadLine());

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Pow(a, 2) / Pow(b, 2);
Console.WriteLine("x={0} \n",x);

y = (5 * (a + b) * (c - d)) / (1.0/2 * c) + Pow(d, 2) * (((Pow(a, 2) - Pow(b, 2)) / (b - a)));
Console.WriteLine("y={0} \n", y);

z = ((Pow((Pow(x, 2) - 2 * x), 3) - 4 * (Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine("z={0} \n", z);

r = (0.5 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + (1 / (a - c));
Console.WriteLine("r={0} \n", r);




