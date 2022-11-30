
double a, b, c, d;
Console.Write("Введіть число а: ");
a = double.Parse(Console.ReadLine());
Console.Write("Введіть число b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Введіть число c: ");
c = double.Parse(Console.ReadLine());
Console.Write("Введіть число d: ");
d = double.Parse(Console.ReadLine());
double x, y, z, r;

x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
y = ((5 * (a + b) * (c - d)) / (c * 0.5)) + d * d * ((a * a - b * b) / (b - a));
z = ((Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1))*(1 - b)) / (5 * a - 3 * b);
r = ((0.5 * a + 0.75 * b - (7 / 5)) / (3 * c + 1)) + (1 / (a - c));
Console.WriteLine($"x = {x}\ny = {y}\nz = {z}\nr = {r}");