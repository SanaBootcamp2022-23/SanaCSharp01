// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

double a, b, c, d;

Console.Write("Введiть значення змiннiй а:");
a = double.Parse(Console.ReadLine());
Console.Write("Введiть значення змiннiй b:");
b = double.Parse(Console.ReadLine());
Console.Write("Введiть значення змiннiй c:");
c = double.Parse(Console.ReadLine());
Console.Write("Введiть значення змiннiй d:");
d = double.Parse(Console.ReadLine());


double x = (a+2*b-c+d)/(c*d) + (a+b)/(c-d) - Math.Pow(a,2)/Math.Pow(b,2);
Console.WriteLine("х = {0}", x);

double y = ( 5 * ( a + b )*(c-d))/(0.5*c) - (Math.Pow(d,2)) *(Math.Pow(a,2) - Math.Pow(b,2))/(b-a);
Console.WriteLine("y = {0}", y);

double z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / 5 * a + 3 * b;
Console.WriteLine("z = {0}", z);

double r = (0.5 * a + (3 / 4) * b - (7 / 5)) / (3 * c + 1) + (1) / (a - c);
Console.WriteLine("r = {0}", r);