// See https://aka.ms/new-console-template for more information
double x, y, z, r, a, b, c, d;
Console.WriteLine("Enter variable values:");
Console.Write("a = "); a = double.Parse(Console.ReadLine());
Console.Write("b = "); b = double.Parse(Console.ReadLine());
Console.Write("c = "); c = double.Parse(Console.ReadLine());
Console.Write("d = "); d = double.Parse(Console.ReadLine());

Console.WriteLine("\nx = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b))");    
x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
Console.WriteLine($"x = {x}\n");

Console.WriteLine("y = ((5 * (a + b) * (c - d)) / (0.5 * c)) + (d * d) * (((a * a) - (b * b)) / (b - a))");
y = ((5 * (a + b) * (c - d)) / (0.5 * c)) + (d * d) * (((a * a) - (b * b)) / (b - a));
Console.WriteLine($"y = {y}\n");

Console.Write("Enter value x = "); x = double.Parse(Console.ReadLine());
Console.WriteLine("\nz = ((Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b))");
z = ((Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b));
Console.WriteLine($"z = {z}\n");

Console.WriteLine("r = (((0.5 * a + 0.75 * b - 1.4) / (3 * c) + 1) + (1 / (a - c)))");
r = (((0.5 * a + 0.75 * b - 1.4) / ((3 * c) + 1)) + (1 / (a - c)));
Console.WriteLine($"r = {r}");