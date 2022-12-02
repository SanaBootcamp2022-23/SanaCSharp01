Console.WriteLine("Enter the number (m)");
double m = double.Parse(Console.ReadLine());


Console.WriteLine("Enter the number (n)");
double n = double.Parse(Console.ReadLine());


Console.WriteLine("Enter the number (x)");
double x = double.Parse(Console.ReadLine());


Console.WriteLine("Enter the number (a)");
double a = double.Parse(Console.ReadLine());


Console.WriteLine("Enter the number (b)");
double b = double.Parse(Console.ReadLine());


double z1 = ((m - 1.0) * Math.Sqrt(m) - (n - 1.0) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + (m * m) - m);

double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

double y = 2.4 * (Math.Abs((x * x + b) / a)) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("z1 = " + z1);
Console.WriteLine("z2 = " + z2);
Console.WriteLine("y = " + y);
