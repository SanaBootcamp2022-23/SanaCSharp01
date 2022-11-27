using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
CultureInfo customCulture = (CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double m, n;
double z1, z2;
double x, b, a;
double y;
Console.WriteLine("Введіть m");
m = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть n");
n = double.Parse(Console.ReadLine());
z1 = (((m-1)*Math.Sqrt(m))-((n-1)*Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m,3)*n) + n*m + Math.Pow(m,2)-m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine("Введіть x");
x = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть a");
a = double.Parse(Console.ReadLine());
y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + ((a-b)*Math.Pow(Math.Sin(a-b),2)) + (Math.Pow(10,-2)*(x-b));
Console.WriteLine($"z1={z1}, z2={z2}, y={y}", z1, z2, y);