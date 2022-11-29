Console.OutputEncoding = System.Text.Encoding.Default;

double m, n;
Console.WriteLine("Введіть число m: ");
m = Double.Parse(Console.ReadLine());

Console.WriteLine("Введіть число n: ");
n = Double.Parse(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Pow(Math.Pow(m,3) * n, 1.0 / 3) + n * m + Math.Pow(m,2) - m);
Console.WriteLine($"z1 = {z1}");

double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"z2 = {z2}");

double a, b, x;
Console.WriteLine("Введіть число a: ");
a = Double.Parse(Console.ReadLine());

Console.WriteLine("Введіть число b: ");
b = Double.Parse(Console.ReadLine());

Console.WriteLine("Введіть число x: ");
x = Double.Parse(Console.ReadLine());

double y = 2.4*Math.Abs((x*x+b)/a) + (a-b)*Math.Pow(Math.Sin(a - b),2)+Math.Pow(10,-2)*(x-b);

Console.WriteLine($"y = {y}");