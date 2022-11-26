double a, b, c, d,
    x, y, z, r;


Console.Write("Введіть число a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Введіть число b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Введіть число c: ");
c = double.Parse(Console.ReadLine());
Console.Write("Введіть число d: ");
d = double.Parse(Console.ReadLine());


x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
Console.WriteLine($"\nРезультат:\n\tx = {x}");

y = 5 * (a + b) * (c - d) / (1.0 / 2 * c) + (Math.Pow(d, 2) * ((a * a - b * b) / (b - a)));
Console.WriteLine($"\ty = {y}");

z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
Console.WriteLine($"\tz = {z}");

r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1.0 / (a - c);
Console.WriteLine($"\tr = {r}");
