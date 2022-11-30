double a, b, x, m,n;
Console.Write("Введіть число а: ");
a = double.Parse(Console.ReadLine());
Console.Write("Введіть число b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Введіть число x: ");
x = double.Parse(Console.ReadLine());
Console.Write("Введіть число m: ");
m = double.Parse(Console.ReadLine());
Console.Write("Введіть число n: ");
n = double.Parse(Console.ReadLine());
double z1, z2, y;

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * x - b;
Console.WriteLine($"z1 = {z1}\nz2 = {z2}\ny = {y}");