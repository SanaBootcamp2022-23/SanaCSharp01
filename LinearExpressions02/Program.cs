double z1, z2, x, y, a, b, m, n;

Console.WriteLine("Введіть число a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число m");
m = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число n");
n = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число x");
x = double.Parse(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + m * n + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs(Math.Pow(x, 2) + b / a) + (a - b) * Math.Pow(Math.Sin(a + b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine($"z1 = {z1:F}\nz2 = {z2:F}\ny = {y:F}");