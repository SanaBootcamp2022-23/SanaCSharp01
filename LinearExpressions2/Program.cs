// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double m, n, a, b, x;
Console.WriteLine("Введіть змінну m:");
m = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть змінну n:");
n = double.Parse(Console.ReadLine());
double z1 = ((m - 1) * Math.Pow(m, 0.5) - (n - 1) * Math.Pow(n, 0.5)) / (Math.Pow(Math.Pow(m, 3) * n, 0.5) + n * m + m * m - m);
Console.WriteLine($"z1= {z1}");
double z2 = (Math.Pow(m, 0.5) - Math.Pow(n, 0.5)) / m;
Console.WriteLine($"z2= {z2}");
Console.WriteLine("Введіть значення a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення x:");
x = double.Parse(Console.ReadLine());
double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"y={y}");