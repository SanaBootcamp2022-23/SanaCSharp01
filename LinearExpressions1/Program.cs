
Console.WriteLine("Enter a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter c:");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter d:");
double d = double.Parse(Console.ReadLine());

double x = (a + 2 * b - c + d) / (c * d);
double y = 5 * (a + b) * (c - d) / (1 / 2 * c) + d * d * (a * a - b * b) / (b - a);
double z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
double r = (1 / 2 * a + 3 / 4 * b - 7 / 5) / (3 * c + 1) + 1 / (a - c);

Console.WriteLine($"x = {x}\ny = {y}\nz = {z}\nr = {r}");