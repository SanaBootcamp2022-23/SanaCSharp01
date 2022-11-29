// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

double z1, z2, y, m, n, x, b, a;

Console.WriteLine("Hello! Let's solve 3 question with fractional variables \"m\", \"n\", \"x\", \"b\" and \"a\".");
Console.WriteLine("Please, use separator \".\" when you'll enter numbers.");
Console.WriteLine("Lets start!");
Console.WriteLine("");

Console.WriteLine("Now, you should input the fractional variable \"m\":");
m = double.Parse(Console.ReadLine());
Console.WriteLine("Graet! Input the fractional variable \"n\":");
n = double.Parse(Console.ReadLine());
Console.WriteLine("");

z1 = (m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n) / (Math.Sqrt (Math.Pow(m,3) * n) +
    n * m + Math.Pow(m,2) - m);
Console.WriteLine($"Result of ((m-1)√m-(n-1)√n)/(√m^3n+nm+m^2-m) is: {z1}");
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"Result of (√m-√n)/m is: {z2}");
Console.WriteLine("");

Console.WriteLine("And lets solve the last question!");
Console.WriteLine("");

Console.WriteLine("Now, you should input the fractional variable \"x\":");
x = double.Parse(Console.ReadLine());
Console.WriteLine("Graet! Input the fractional variable \"b\":");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Graet! Input the fractional variable \"a\":");
a = double.Parse(Console.ReadLine());
Console.WriteLine("");

y = 2.4 * Math.Abs( (Math.Pow(x,2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2)
     + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"Result of 2.4|(x^2+b)/a|+(a-b)+10^-2(x-b) is: {y}");