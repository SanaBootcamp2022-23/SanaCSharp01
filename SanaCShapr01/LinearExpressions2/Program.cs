

double m, n, a, b, x;
Console.Write("Enter m: ");
m = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter n: ");
n = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter x: ");
x = Convert.ToDouble(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / 2) + (a - b) * Math.Pow((Math.Asin(a - b)), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"z1 = {z1}\nz2 = {z2}\ny = {y}");