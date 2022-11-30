Console.WriteLine("Введіть число (a)");
double a = double.Parse(Console.ReadLine());


Console.WriteLine("Введіть число (b)");
double b = double.Parse(Console.ReadLine());


Console.WriteLine("Введіть число (c)");
double c = double.Parse(Console.ReadLine());


Console.WriteLine("Введіть число (d)");
double d = double.Parse(Console.ReadLine());


double x = (a + 2.0 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);

double y = (5.0 * (a + b) * (c - d)) / ((1.0 / 2.0) * c) + (d * d) * ((a * a) - (b * b)) / (b - a);

double z = ((Math.Pow(((x * x) - 2.0 * x), 3) - 4.0 * (Math.Pow(x, 4) + 1.0)) * (1.0 - b)) / (5.0 * a + 3.0 * b);

double r = (1.0 / 2.0 * a + 3.0 / 4.0 * b - 7.0 / 5.0) / (3.0 * c + 1.0) + 1.0 / (a - c);