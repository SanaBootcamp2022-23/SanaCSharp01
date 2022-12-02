
Console.WriteLine("x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a^2 / b^2");
Console.WriteLine("y = (5 * (a + b) * (c - d)) / ((1 / 2) * c) + d^2 * (a^2 - b^2) / (b - a))");
Console.WriteLine("z = ((x^2 - 2 * x)^3 - 4 * (x^2 + 1) * (1 - b)) / (5 * a + 3 * b)");
Console.WriteLine("r = ((1 / 2) * a + (3 / 4) * b - 7 / 5) / (3 * c + 1) + 1 / (a - c)");

Console.WriteLine("\nInput a:");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Input b:");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Input c:");
double c = double.Parse(Console.ReadLine());

Console.WriteLine("Input d:");
double d = double.Parse(Console.ReadLine());

double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
double y = (5 * (a + b) * (c - d)) / ((1 / 2) * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
double z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
double r = ((1 / 2) * a + (3 / 4) * b - 7 / 5) / (3 * c + 1) + 1 / (a - c);

Console.WriteLine($"\nx = {x}\ny = {y}\nz = {z}\nr = {r}");