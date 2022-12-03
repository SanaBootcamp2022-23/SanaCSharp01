Console.Write("m=");
double m = double.Parse(Console.ReadLine());
Console.Write("n=");
double n = double.Parse(Console.ReadLine());
Console.Write("a=");
double a = double.Parse(Console.ReadLine());
Console.Write("b=");
double b = double.Parse(Console.ReadLine());
Console.Write("x=");
double x = double.Parse(Console.ReadLine());


double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) / (n * m) / (m * m) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + 1 / 100 * (x - b);
Console.WriteLine($"z1={z1}\nz2={z2}\ny={y}");