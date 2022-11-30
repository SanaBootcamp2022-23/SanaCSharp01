double a, b, c, d, x, y, z, r;

Console.Write("Введіть число а:");
a = double.Parse(Console.ReadLine());

Console.Write("Введіть число b:");
b = double.Parse(Console.ReadLine());

Console.Write("Введіть число c:");
c = double.Parse(Console.ReadLine());

Console.Write("Введіть число d:");
d = double.Parse(Console.ReadLine());

x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
Console.WriteLine("Перший приклад (x) = {0}", x);

y = ((5 * (a + b) * (c - d)) / ((1 / 2.0) * c)) + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)));
Console.WriteLine("Другий приклад (y) = {0}", y);

z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - (4 * (Math.Pow(x, 4) + 1))) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine("Третій приклад (z) = {0}", z);

r = (((1 / 2.0 * a) + (3 / 4.0 * b) - (7 / 5.0)) / (3 * c + 1)) + (1 / (a - c));
Console.WriteLine("Четвертий приклад (r) = {0}", r);