double m, n;
Console.WriteLine("Fractional number m:");
m = double.Parse(Console.ReadLine());

Console.WriteLine("Fractional number n:");
n = double.Parse(Console.ReadLine());

double resultZ1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
Console.WriteLine($"Z1: \n{resultZ1}");

double resultZ2 = (Math.Sqrt(m) - Math.Sqrt(n)) / (m);
Console.WriteLine($"Z2: \n{resultZ2}");


double a, b, x;
Console.WriteLine("number a:");
a = double.Parse(Console.ReadLine());

Console.WriteLine("number b:");
b = double.Parse(Console.ReadLine());

Console.WriteLine("number x:");
x = double.Parse(Console.ReadLine());

double resultY = (2.4 * Math.Abs((x * x + b) / a)) + ((a - b) * Math.Pow(Math.Sin(a - b), 2)) + ((Math.Pow(10, -2)) * (x - b));
Console.WriteLine("Y = {0}", resultY);