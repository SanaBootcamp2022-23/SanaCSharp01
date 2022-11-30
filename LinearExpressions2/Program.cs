Console.WriteLine("Введіть число (m)");
double m = double.Parse(Console.ReadLine());


Console.WriteLine("Введіть число (n)");
double n = double.Parse(Console.ReadLine());


Console.WriteLine("Введіть число (x)");
double x = double.Parse(Console.ReadLine());


Console.WriteLine("Введіть число (a)");
double a = double.Parse(Console.ReadLine());


Console.WriteLine("Введіть число (b)");
double b = double.Parse(Console.ReadLine());


double z1 = ((m - 1.0) * Math.Sqrt(m) - (n - 1.0) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + (m * m) - m);

double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

double y = 2.4 * (Math.Abs((x * x + b) / a)) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
