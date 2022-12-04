// See https://aka.ms/new-console-template for more information
Console.WriteLine("a=");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b=");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("c=");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("d=");
double d = Convert.ToDouble(Console.ReadLine());
double x, y, z, r;
x = ((a + 2 * b - c + d) / c * d) + (a + b) / (c - d) - (a * a) / (b * b);
y = ((5 * (a + b) * (c - d)) / (1 / 2 * c)) + d * d * (a * a - b * b / (b - a));
z = (((x * x - 2 * x) * (x * x - 2 * x) * (x * x - 2 * x) - 4 * (x * x * x * x + 1)) * (1 - b)) / (5 * a + 3 * b);
r = ((1 / 2 * a + 3 / 4 * b - 1 / 5) / (3 * c + 1)) + 1 / (a - c);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(r);