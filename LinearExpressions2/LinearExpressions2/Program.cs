
// See https://aka.ms/new-console-template for more information
double m, n;
Console.WriteLine("Input m");
m = float.Parse (Console.ReadLine());
Console.WriteLine("Imput n");
n = float.Parse (Console.ReadLine());
double z1,z2;
z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) )+ (m * n) + Math.Pow(m, 2) - m;
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine(z1);
Console.WriteLine(z2);
double x, b, a;
Console.WriteLine("Imput x");
x = float.Parse (Console.ReadLine());
Console.WriteLine("Imput b");
b = float.Parse (Console.ReadLine());
Console.WriteLine("Imput a");
a = float.Parse (Console.ReadLine());
double y;
y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / 2) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine(y);
