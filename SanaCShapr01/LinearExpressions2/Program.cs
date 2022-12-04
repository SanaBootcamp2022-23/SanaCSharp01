// See https://aka.ms/new-console-template for more information

Console.WriteLine("m=");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("n=");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("x=");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b=");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("a=");
double a = Convert.ToDouble(Console.ReadLine());
double z1, z2, y;
z1 = ((m - 1) * Math.Pow(m, 1 / 2) - (n - 1) * Math.Pow(n, 1 / 2)) / (Math.Pow((Math.Pow(m, 3) * n), 1 / 2) + n * m + m * m - m);
z2 = (Math.Pow(m, 1 / 2) - Math.Pow(n, 1 / 2)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b) * Math.Sin(a - b) + Math.Pow(10, -2) * (x - b);
Console.WriteLine(z1);
Console.WriteLine(z2);
Console.WriteLine(y);

