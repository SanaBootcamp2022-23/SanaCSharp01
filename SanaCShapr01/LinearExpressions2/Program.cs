Console.WriteLine("Input number m");
double m;
m = double.Parse(Console.ReadLine());

Console.WriteLine("Input number n");
double n;
n = double.Parse(Console.ReadLine());

Console.WriteLine("Input number a");
double a;
a = double.Parse(Console.ReadLine());

Console.WriteLine("Input number b");
double b;
b = double.Parse(Console.ReadLine());

Console.WriteLine("Input number x");
double x;
x = double.Parse(Console.ReadLine());

double z1;
z1 = ((m - 1.0) * Math.Sqrt(m) - (n - 1.0) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
Console.WriteLine($"Result of calculating z1: {z1}");

double z2;
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"Result of calculating z2: {z2}");

double y;
y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"Result of calculating y: {y}");



