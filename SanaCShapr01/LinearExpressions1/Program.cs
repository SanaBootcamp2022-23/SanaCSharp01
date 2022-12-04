double a, b, c, d, x, y, z, r;

Console.Write("Input a: ");
a = double.Parse(Console.ReadLine());

Console.Write("Input b: ");
b = double.Parse(Console.ReadLine());

Console.Write("Input c: ");
c = double.Parse(Console.ReadLine());

Console.Write("Input d: ");
d = double.Parse(Console.ReadLine());

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
Console.WriteLine("x = {0:0.00}", x);

y = (5 * (a + b) * (c - d)) / (0.5 * c) + d * d * (a * a - b * b) / (b - a);
Console.WriteLine("y = {0:0.00}", y);

z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
Console.WriteLine("z = {0:0.00}", z);

r = (0.5 * a + 0.75 * b - 1.4) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine("r = {0:0.00}", r);
