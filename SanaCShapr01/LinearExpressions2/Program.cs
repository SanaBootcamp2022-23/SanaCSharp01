using static System.Math;

double a, b, x, m, n, z1, z2, y;

Console.Write("Enter value a: ");
a = double.Parse(Console.ReadLine());

Console.Write("Enter value b: ");
b = double.Parse(Console.ReadLine());

Console.Write("Enter value x: ");
x = double.Parse(Console.ReadLine());

Console.Write("Enter value m: ");
m = double.Parse(Console.ReadLine());

Console.Write("Enter value n: ");
n = double.Parse(Console.ReadLine());



z1 = ((m - 1) * Sqrt(m) - (n - 1) * Sqrt(n))
    / (Sqrt(Pow(m, 3) * n) + (n * m) + Pow(m, 2) - m);
Console.WriteLine("z1 = {0:F3}", z1);


z2 = (Sqrt(m) - Sqrt(n))
    / m;
Console.WriteLine("z2 = {0:F3}", z2);


y = 2.4 * Abs((Pow(x, 2) + b)
                        / a) + (a - b) * Pow(Sin(a - b), 2) + Pow(10, -2) * (x - b);
Console.WriteLine("y = {0:F3}", y);