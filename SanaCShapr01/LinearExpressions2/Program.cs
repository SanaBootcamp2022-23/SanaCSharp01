double a, b, x, m, n, y, z1, z2;

Console.Write("Введіть число а:");
a = double.Parse(Console.ReadLine());

Console.Write("Введіть число b:");
b = double.Parse(Console.ReadLine());

Console.Write("Введіть число m:");
m = double.Parse(Console.ReadLine());

Console.Write("Введіть число n:");
n = double.Parse(Console.ReadLine());

Console.Write("Введіть число x:");
x = double.Parse(Console.ReadLine());

z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / ((Math.Sqrt(Math.Pow(m, 3) * n)) + (n * m) + Math.Pow(m, 2) - m);
Console.WriteLine("Приклад (z1) = {0}", z1);

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine("Приклад (z2) = {0}", z2);

y = 2.4 * (Math.Abs((Math.Pow(x, 2) + b) / a)) + (a - b) * (Math.Pow(Math.Sin(a - b), 2)) + Math.Pow(10, -2) * (x - b);
Console.WriteLine("Приклад (y) = {0}", y);