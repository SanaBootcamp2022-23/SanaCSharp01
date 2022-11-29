using System.Globalization;
using System.Threading;

CultureInfo customCulture = (CultureInfo)
Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

double m = 1, n = 1, x = 1, a = 1, b = 1;
Console.WriteLine("Please print five double numbers :");
Console.Write("Number m:");
bool flag = double.TryParse(Console.ReadLine(), out var m1);
if (flag)
{
    m = m1;
}
Console.Write("Number n:");
flag = double.TryParse(Console.ReadLine(), out var n1);
if (flag)
{
    n = n1;
}
Console.Write("Number x:");
flag = double.TryParse(Console.ReadLine(), out var x1);
if (flag)
{
    x = x1;
}
Console.Write("Number b:");
flag = double.TryParse(Console.ReadLine(), out var b1);
if (flag)
{
    b = b1;
}
Console.Write("Number a:");
flag = double.TryParse(Console.ReadLine(), out var a1);
if (flag)
{
    a = a1;
}
try
{
    double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
    if ( (Math.Sqrt(m * m * m * n)+n*m+m*m-m)==0) { throw new DivideByZeroException(); }
    else if(m < 0 || n < 0 ) { throw new Exception("Square root by negative number"); }
    Console.WriteLine("z1 = {0}", z1);
    double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
    Console.WriteLine("z2 = {0}", z2);
    double y = 2.4 * Math.Abs((x * x + b) / a)+(a-b)*Math.Pow(Math.Sin(a-b),2)+(x-b)/100;
    if (a==0) { throw new DivideByZeroException(); }
    Console.WriteLine("y = {0}", y);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);

}
