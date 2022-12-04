using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
CultureInfo customCulture = (CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, c, d;
double x, y, z, r;
Console.WriteLine("Введіть a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть c");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть d");
d = double.Parse(Console.ReadLine());
x = ((a+2*b-c+d)/(c*d))+((a+b)/(c-d))-(Math.Pow(a,2)/Math.Pow(b,2));
y = ((5 * (a + b) * (c - d)) / (0.5 * c)) + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)));
z = ((Math.Pow(Math.Pow(x,2)-2*x,3) - 4*(Math.Pow(x,4)+1))*(1-b))/(5 * a + 3 * b);
r = ((0.5*a+(3/4)*b-(7/5))/(3*c+1)) + (1 / (a - c));
Console.WriteLine($"x={x}, y={y}, z={z}, r={r}",x,y,z,r);

