Console.OutputEncoding = System.Text.Encoding.Default;

double a, b, c, d;
Console.WriteLine("Введіть число а: ");
a = Double.Parse(Console.ReadLine());

Console.WriteLine("Введіть число b: ");
b = Double.Parse(Console.ReadLine());

Console.WriteLine("Введіть число c: ");
c = Double.Parse(Console.ReadLine());

Console.WriteLine("Введіть число d: ");
d = Double.Parse(Console.ReadLine());

double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));

Console.WriteLine($"x = {x}");

double y = ((5 * (a + b) * (c - d)) / (c / 2)) + (d * d * (a * a - b * b) / (b - a));

Console.WriteLine($"y = {y}");

double z = ((Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);

Console.WriteLine($"z = {z}");

double r = ((a / 2 + 3 * b / 4 - 7 / 5) / (3 * c + 1)) + (1 / (a - c));

Console.WriteLine($"r = {r}");