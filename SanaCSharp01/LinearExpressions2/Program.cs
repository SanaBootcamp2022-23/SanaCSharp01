using static System.Math;
double a, b, n, m, x, y, z1, z2;
Console.WriteLine("Enter a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter n:");
n = double.Parse(Console.ReadLine());
Console.WriteLine("Enter m:");
m = double.Parse(Console.ReadLine());
Console.WriteLine("Enter x:");
x = double.Parse(Console.ReadLine());
//Expressions
z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"\nZ1 = {z1}");
Console.WriteLine($"Z2 = {z2}");
Console.WriteLine($"Y  = {y}");
