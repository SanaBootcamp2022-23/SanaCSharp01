
double m, n, a, b, x;

Console.WriteLine("Enter m:");
n = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter n:");
m = double.Parse(Console.ReadLine() ?? "0");

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / 
    (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

Console.WriteLine($"z1 = {z1}\nz2 = {z2}");

Console.WriteLine("Enter a:");
a = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter b:");
b = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter x:");
x = double.Parse(Console.ReadLine() ?? "0");

double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * 
    Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("y = {0}", y);