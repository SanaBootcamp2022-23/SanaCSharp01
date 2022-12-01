// See https://aka.ms/new-console-template for more information
double a, b, c, d;
Console.WriteLine("Input a");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Input b");
b = float.Parse(Console.ReadLine());
Console.WriteLine("Input c");
c = float.Parse(Console.ReadLine());
Console.WriteLine("Input c");
d = float.Parse(Console.ReadLine());
double x,y,z,r;
x = (a + Math.Pow( a, 2) - c + d / (c * d)) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
Console.WriteLine(x);
