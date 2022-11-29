// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Введiть значення m, n");
Console.Write("m = ");
double m = double.Parse(Console.ReadLine());
Console.Write("n = ");
double n = double.Parse(Console.ReadLine());
double z1, z2, y;
z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n))/(Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine("z1 = " + z1 + "\nz2 = " + z2);

Console.WriteLine("\nДля другого виразу введіть 3 значення: a, b, x.");
double x, a, b;
Console.Write("a = ");
a = double.Parse(Console.ReadLine());
Console.Write("b = ");
b = double.Parse(Console.ReadLine());
Console.Write("x = ");
x = double.Parse(Console.ReadLine());
y = 2.4 * Math.Abs(Math.Pow(x, 2) + b / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine("y = " + y);
