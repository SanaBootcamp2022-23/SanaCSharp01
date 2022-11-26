using static System.Math;

double a, b, c, d;
Console.Write("Input a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Input b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Input c: ");
c = double.Parse(Console.ReadLine());
Console.Write("Input d: ");
d = double.Parse(Console.ReadLine());
double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Pow(a, 2) / Pow(b, 2));
Console.WriteLine($"x= {x}");
double y = ((5 * (a + b) * (c - d)) / ((1 / 2.0) * c)) + (Pow(d, 2) * ((Pow(a, 2) - Pow(b, 2)) / (b - a)));
Console.WriteLine($"y= {y}");
double z = ((Pow((Pow(x, 2) - 2 * x), 3) - 4 * (Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine($"z= {z}");
double r = ((1 / 2.0 * a + 3 / 4.0 * b - 7 / 5.0) / (3 * c + 1)) + (1 / (a - c));
Console.WriteLine($"r= {r}");