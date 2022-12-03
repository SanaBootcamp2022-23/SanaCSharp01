using System.Globalization;
using System.Threading;

CultureInfo customCulture = (CultureInfo)
    Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, c, d, x, y, z, r;
Console.WriteLine("Введіть змінну a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть змінну b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть змінну c:");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть змінну d:");
d = double.Parse(Console.ReadLine());
x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
Console.WriteLine($" X= {x}");
y = ((5 * (a + b) * (c - d)) / (0.5 * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)));
Console.WriteLine($" Y= {y}");
z = (((Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b));
Console.WriteLine($" Z= {z}");
r = (((0.5 * a + 0.75 * b - 1.4) / (3 * c + 1)) + 1 / (a - c));
Console.WriteLine($" R= {r}");
