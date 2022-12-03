Console.WriteLine("m: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("n: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b: ");
double b = Convert.ToDouble(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(n * m * m * m) + n * m + m * m - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b) * Math.Sin(a - b) + 0.01 * (x - b);

Console.WriteLine("---Results---");

Console.WriteLine("z1: " + z1);
Console.WriteLine("z2: " + z2);
Console.WriteLine("y: " + y);
