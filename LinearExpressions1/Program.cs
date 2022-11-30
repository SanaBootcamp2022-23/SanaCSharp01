// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator= ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, c, d;
Console.WriteLine("Enter the value a");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the value b");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the value c");
c = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the value d");
d = double.Parse(Console.ReadLine());

double x = ((a + (2.0 * b) - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));

double y = ((5 * ((a + b) * (c - d))) / (0.5 * c)) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));

double z = ((Math.Pow(Math.Pow(x, 2) - (2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / ((5 * a) + (3 * b));

double r = ((0.5 * a) + (0.75 * b) - (7 / 5)) / (3 * c + 1) + (1 / (a - c));

Console.WriteLine($"The first formula X = {x} \n" +
    $"The second formula Y = {y} \n" +
    $"The third formula Z = {z} \n" +
    $"The fourth formula R = {r}");