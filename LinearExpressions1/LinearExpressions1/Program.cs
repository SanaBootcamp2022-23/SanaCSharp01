using System.Globalization;
using System.Threading;

CultureInfo customCulture = (CultureInfo)
Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

double a = 1, b = 1, c = 1, d = 1;
Console.WriteLine("Please print four double numbers :");
Console.Write("Number a:");
bool flag =double.TryParse(Console.ReadLine(),out var a1);
if (flag)
{
     a = a1;
}
Console.Write("Number b:");
flag = double.TryParse(Console.ReadLine(), out var b1);
if (flag)
{
     b = b1;
}
Console.Write("Number c:");
flag = double.TryParse(Console.ReadLine(), out var c1);
if (flag)
{
     c = c1;
}
Console.Write("Number d:");
flag = double.TryParse(Console.ReadLine(), out var d1);
if (flag)
{
     d = d1;
}
try
{
    double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a * a / (b * b);
    if (c == 0 || d == 0 || (c - d) == 0) throw new DivideByZeroException();
    Console.WriteLine("x = {0}", x);
    double y = 5.0 * (a + b) * (c - d) * 2.0 / c + d * d * (a * a - b * b) / (b - a);
    if (b-a==0) throw new DivideByZeroException();
    Console.WriteLine("y = {0}", y);
    double z = (Math.Pow((x * x - 2 * x), 3) - 4 * (x * x * x * x + 1)) * (1 - b) / (5 * a + 3 * b);
    if (5 * a + 3 * b == 0) throw new DivideByZeroException();
    Console.WriteLine("z = {0}", z);
    double r = (a / 2.0 + 3 * b / 4.0 - 7 / 5.0) / (3 * c + 1) + 1 / (a - c);
    if ((3 * c + 1)==0|| (a - c)==0) throw new DivideByZeroException();
    Console.WriteLine("r = {0}", r);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);

}
