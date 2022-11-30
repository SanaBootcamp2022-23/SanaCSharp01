using System.Globalization;
using System.Text;
using System.Threading;

Console.OutputEncoding = Encoding.UTF8;

CultureInfo customCulture = (CultureInfo)
Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, m, n, x, z1, z2, y;

Console.Write("Введіть a - ");   a = double.Parse(Console.ReadLine());
Console.Write("Тепер b - ");     b = double.Parse(Console.ReadLine());
Console.Write("Ще m - ");        m = double.Parse(Console.ReadLine());
Console.Write("n - ");           n = double.Parse(Console.ReadLine());
Console.Write("Накінець x - ");  x = double.Parse(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine($"Результати обчислень:\n z1 = {z1}\n z2 = {z2}\n y = {y} ");