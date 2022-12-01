// See https://aka.ms/new-console-template for more information
double a, b, c, d;
Console.WriteLine("Input a");
a = float.Parse(Console.ReadLine());
Console.WriteLine("Input b");
b = float.Parse(Console.ReadLine());
Console.WriteLine("Input c");
c = float.Parse(Console.ReadLine());
Console.WriteLine("Input d");
d = float.Parse(Console.ReadLine());
double x,y,z,r;
x = (a + Math.Pow( a, 2) - c + d / (c * d)) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
Console.WriteLine(Math.Round(x,3));
y = (5 * (a + b) * (c - d) / (c / 2) + Math.Pow(d, 2) * (Math.Pow(b, 2))) / (b - a);
Console.WriteLine(Math.Round(y,3));
z = Math.Pow((Math.Pow(x, 2)) - (2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b) / (5 * a) + (3 * b);
Console.WriteLine(Math.Round(z,3));
r = (1 / 2 * 2 + 1 / 4 / b - 7 / 5) / (3 * c + 1) + (1 / (a - c));
Console.WriteLine(Math.Round(r,3));
