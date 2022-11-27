// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please, enter 4 numbers for calculation.");

Console.Write("Enter first number (a): ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number (b): ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter third number (c): ");
double c = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter last number (d): ");
double d = Convert.ToDouble(Console.ReadLine());


double x = ((a + (2 * b) - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
Console.WriteLine($"\nx = {x}");

double y = (5 * ((a + b) * (c - d))) / (0.5 * c) + (Math.Pow(d, 2) * (((Math.Pow(a, 2)) - Math.Pow(b, 2)) / (b - a)));
Console.WriteLine($"\ny = {y}");
x = 5;
double z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / ((5 * a) + (3 * b));

Console.WriteLine($"\nz = {z}");

double r = (((0.5 * a) + ((3.0 / 4.0) * b) - (7.0 / 5.0)) / ((3.0 * c) + 1.0)) + (1.0 / (a - c));
Console.WriteLine($"\nr = {r}");
