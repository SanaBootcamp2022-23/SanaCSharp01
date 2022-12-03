// See https://aka.ms/new-console-template for more information
double a, b, c, d;
Console.WriteLine("Enter variable a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter variable b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter variable c:");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter variable d:");
d = double.Parse(Console.ReadLine());
double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
double y = (5 * (a + b) * (c - d)) / (1 / 2 * c) + (d * d) * ((a * a - b * b) / (b - a));
double z = ((Math.Pow((x * x - 2 * x), 3) - 4 * (x * x * x * x + 1)) * (1 - b)) / (5 * a + 3 * b);
double r = (1 / 2 * a + 3 / 4 * b - 7 / 5) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine($"Result x = {x}");
Console.WriteLine($"Result y = {y}");
Console.WriteLine($"Result z = {z}");
Console.WriteLine($"Result r = {r}");