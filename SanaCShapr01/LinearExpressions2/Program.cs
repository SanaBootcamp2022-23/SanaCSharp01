// See https://aka.ms/new-console-template for more information
//SanaCShapr01
//Bohdan Serdeniuk

using System.Globalization;

double m, n, x, a, b, z1, z2, y;

//dot as separator
CultureInfo customCulture = (CultureInfo)
    Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

//initialization of variables
Console.WriteLine("enter the number m");
m = double.Parse(Console.ReadLine());
Console.WriteLine("enter the number n");
n = double.Parse(Console.ReadLine());
Console.WriteLine("enter the number x");
x = double.Parse(Console.ReadLine());
Console.WriteLine("enter the number a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("enter the number b");
b = double.Parse(Console.ReadLine());

//calculation of the result and output of the result
// Math.Pow(a, 2.0)
// Math.Sqrt(m)
// Math.Abs(Double)
// Math.Sin(Double)
z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3.0) * n) + n * m + Math.Pow(m, 2.0) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((Math.Pow(x, 2.0) + b) / a) + (a - b) * ((1 - Math.Cos(2 * (a - b))) / 2) + (Math.Pow(10, -2.0) * (x - b));

Console.WriteLine("results:\nz1 = {0} ,\nz2 = {1} ,\ny = {2}", z1, z2, y);