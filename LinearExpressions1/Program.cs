
static double CalculateX(double a, double b, double c, double d)
{
    double x;
    x = ((a + (2 * b) - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(c, 2));
    return x;
}
static double CalculateY(double a, double b, double c, double d)
{
    double y;
    y = ((5 * (a + b) * (c - d)) / (0.5 * c)) + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)));
    return y;
}
static double CalculateZ(double a, double b, double d, double x)
{
    double z;
    z = (Math.Pow((Math.Pow(x, 2) - (2 * x)), 3) - (4 * (Math.Pow(x, 4) + 1) * (1 - b))) / ((5 * a) + (3 * b));
    return z;
}
static double CalculateR(double a, double b, double c)
{
    double r;
    r = (((0.5 * a) + (0.75 * b) - 1.4) / ((3 * c) + 1)) + (1 / (a - c));
    return r;
}
double a, b, c, d, x;

Console.WriteLine("Input number a");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Input number b");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Input number c");
c = double.Parse(Console.ReadLine());

Console.WriteLine("Input number d");
d = double.Parse(Console.ReadLine());

Console.WriteLine("Input number x");
x = double.Parse(Console.ReadLine());


Console.WriteLine($"\n x = {CalculateX(a, b, c, d)} " +
    $"\n y = {CalculateY(a, b, c, d)} " +
    $"\n z = {CalculateZ(a, b, d, x)} " +
    $"\n r = {CalculateR(a, b, c)}");