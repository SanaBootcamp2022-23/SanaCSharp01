double a, b, c, d, x, y, z, r;

Console.WriteLine("Введіть число a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число c");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число d");
d = double.Parse(Console.ReadLine());

x = (a + 2 * b - c + d)/(c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
y = (5 * (a + b) * (c + d)) / ((1 / 2.0) * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
z = ((Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1.0 - b)) / (5 * a + 3 * b);
r = (1 / 2.0 * a + 3 / 4.0 * b - 7 / 5.0) / (3 * c + 1) + 1.0 / (a - c);

Console.WriteLine($"x = {x:F}\ny = {y}\n z = {z}\nr = {r:F}");