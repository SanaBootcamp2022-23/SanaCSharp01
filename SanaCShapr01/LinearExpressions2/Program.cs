// See https://aka.ms/new-console-template for more information


double a, b, x, m, n;
Console.Write("a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("m: ");
m = Convert.ToDouble(Console.ReadLine());
Console.Write("n: ");
n = Convert.ToDouble(Console.ReadLine());

double z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(m) ) / (Math.Sqrt(Math.Pow(m, 3) * n) + (m * n) + Math.Pow(m, 2) - m));
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

// формула сінуса в квадраті
double num = a - b;
double sinPow2 = (1f - Math.Cos(2f * num) / 2f);

double y = (2.4f * Math.Abs( (x * x + b) / a )) + ((a - b) * sinPow2) + (Math.Pow(1f / 10, 2f) * (x - b));

Console.WriteLine("Z1: " + z1.ToString());
Console.WriteLine("Z2: " + z2.ToString());
Console.WriteLine("Y: " + y.ToString());
