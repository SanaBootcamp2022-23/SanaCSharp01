using System.Security.Cryptography.X509Certificates;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.Write("Введіть m: ");
double m = double.Parse(Console.ReadLine());
Console.Write("Введіть n: ");
double n = double.Parse(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

Console.WriteLine($"Значення z1: {z1}\nЗначення z2: {z2}");


Console.Write("Введіть a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введіть b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введіть x: ");
double x = double.Parse(Console.ReadLine());

double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"Значення у: {y}");
