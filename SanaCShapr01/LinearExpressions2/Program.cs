using static System.Math;

double a, b, x, m, n, z1, z2, y;

/*Console.Write("Enter value a: ");
a = double.Parse(Console.ReadLine());

Console.Write("Enter value b: ");
b = double.Parse(Console.ReadLine());

Console.Write("Enter value x: ");
x = double.Parse(Console.ReadLine());

Console.Write("Enter value m: ");
m = double.Parse(Console.ReadLine());

Console.Write("Enter value n: ");
n = double.Parse(Console.ReadLine());
*/

a = 1;
b = 2;
x = 3;
m = 4;
n = 5;

z1 = ((m - 1) * Sqrt(m) - (n - 1) * Sqrt(n))
    / (Sqrt(Pow(m, 3) * n) + (n * m) + Pow(m, 2) - m);
Console.WriteLine("z1 = {0:F3}", z1);