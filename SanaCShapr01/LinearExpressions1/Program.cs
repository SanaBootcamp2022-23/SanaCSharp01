// See https://aka.ms/new-console-template for more information
//SanaCShapr01
//Bohdan Serdeniuk

using System.Globalization;

double a, b, c, d, x, y, z, r;

//dot as separator
CultureInfo customCulture = (CultureInfo)
    Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

//initialization of variables
Console.WriteLine("enter the number a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("enter the number b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("enter the number c");
c = double.Parse(Console.ReadLine());
Console.WriteLine("enter the number d");
d = double.Parse(Console.ReadLine());

//calculation of the result and output of the result
x = (((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((Math.Pow(a, 2.0)) / (Math.Pow(b, 2.0))));
y = ((5 * (a + b) * (c - d)) / ((1.0 / 2.0) * c)) + (Math.Pow(d, 2.0) * (((Math.Pow(a, 2.0)) - (Math.Pow(b, 2.0))) / (b - a)));
z = (((Math.Pow((Math.Pow(x, 2.0)) - (2 * x), 3.0)) - (4 * ((Math.Pow(x, 4.0)) + 1))) * (1 - b)) / (5 * a + 3 * b);
r = (((1.0 / 2.0) * a) + ((3.0 / 4.0) * b) - (7.0 / 5.0)) / (3 * c + 1) + (1 / (a - c));

Console.WriteLine("results:\nx = {0} ,\ny = {1} ,\nz = {2} ,\nr = {3}", x, y, z, r);