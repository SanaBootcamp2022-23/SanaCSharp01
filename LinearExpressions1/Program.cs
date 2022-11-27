using System.Text;
using System.Globalization;
using System.Threading;

Console.OutputEncoding = Encoding.UTF8;

CultureInfo customCulture = (CultureInfo)
Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, c, d, x, y, z, r;

Console.Write("Введіть a - ");  a = double.Parse(Console.ReadLine());
Console.Write("Тепер b - ");    b = double.Parse(Console.ReadLine());
Console.Write("Ще c - ");       c = double.Parse(Console.ReadLine());
Console.Write("Накінець d - "); d = double.Parse(Console.ReadLine());

x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (a * a) / (b * b);
y = ((5 * (a + b) * (c - d)) / (1/2 * c)) + (d * d) * ((a * a - b * b) / (b - a));
z = ((Math.Pow((x * x) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
r = (((1 / 2) * a + (3 / 4) * b - 7 / 5) / 3 * c + 1) + 1 / (a - c);

Console.WriteLine($"Результати обчислень виразів:\n x = {x}\n y = {y}\n z = {z}\n r = {r}");
Console.ReadKey();