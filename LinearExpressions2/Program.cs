
double CalculateZ1(double a, double b, double x, double n, double m)
{
    double z1;
    z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
    return z1;
}
double CalculateZ2(double n, double m)
{
    double z2;
    z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
    return z2;
}
double CalculateY(double a, double b, double x)
{
    double y;
    y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
    return y;
}

double n, m, x, a, b;

Console.WriteLine("Input number a");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Input number b");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Input number x");
x = double.Parse(Console.ReadLine());

Console.WriteLine("Input number n");
n = double.Parse(Console.ReadLine());

Console.WriteLine("Input number m");
m = double.Parse(Console.ReadLine());


Console.WriteLine($"\n z1 = {CalculateZ1(a, b, x, n, m)} " +
    $"\n z2 = {CalculateZ2(n, m)} " +
    $"\n y = {CalculateY(a, b, x)} ");

