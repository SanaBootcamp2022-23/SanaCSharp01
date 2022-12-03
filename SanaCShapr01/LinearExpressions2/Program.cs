using System.Globalization;
using System.Threading;

CultureInfo customCulture = (CultureInfo)
    Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

double m, n, a, b, x;
Console.WriteLine("Введіть змінну m:");
m = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть змінну n:");
n = double.Parse(Console.ReadLine());
double z1=(((m-1)*Math.Sqrt(m)-(n-1)*Math.Sqrt(n))/(Math.Sqrt(Math.Pow(m,3)*n)+n*m+Math.Pow(m,2)-m));
Console.WriteLine($"z1= {z1}");
double z2 = ((Math.Sqrt(m) - Math.Sqrt(n)) / m);
Console.WriteLine($"z2= {z2}");
Console.WriteLine("Введіть значення a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення x:");
x = double.Parse(Console.ReadLine());
double y = (2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b));
Console.WriteLine($"y={y}");