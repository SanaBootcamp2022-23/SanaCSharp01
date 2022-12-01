// See https://aka.ms/new-console-template for more information
double a, b, x, y, z1, z2, m, n;
bool tof;
Console.Write("Введіть значення m: ");
m = double.Parse(Console.ReadLine());
Console.Write("Введіть значення n: ");
n = double.Parse(Console.ReadLine());
Console.Write("Введіть значення x: ");
x = double.Parse(Console.ReadLine());
Console.Write("Введіть значення a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Введіть значення b: ");
b = double.Parse(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n-1)*Math.Sqrt(n))/(Math.Sqrt(Math.Pow(m,3)*n) + m*n + Math.Pow(m,2) - m);

z2 = (Math.Sqrt(m) - Math.Sqrt(n))/m;

y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b),2) + Math.Pow(10,-2)*(x-b);

Console.WriteLine($"z1 = {z1}\nz2 = {z2}\ny = {y}");
