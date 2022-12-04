double a, b, c, d, x, y, z, r;

Console.WriteLine("Enter a = ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter b = ");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter c = ");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter d = ");
d = Convert.ToDouble(Console.ReadLine());

x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
Console.WriteLine($"x = {x}");

y = (5 * (a + b) * (c - d)) / (0.5 * c) + (d * d) * (a * a - b * b) / (b - a);
Console.WriteLine($"y = {y}");

z = (Math.Pow((x * x - 2 * x), 3) - 4 * (x * x * x * x + 1) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine($"z = {z}");

r = ((0.5 * a + 0.75 * b - 1.4) / (3 * c + 1)) + ((1 / (a - c)));
Console.WriteLine($"r = {r}");