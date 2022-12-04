using LinearExpressions1;


Console.WriteLine("enter m:");
double m = double.Parse(Console.ReadLine());
Console.WriteLine("enter n:");
double n = double.Parse(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / ((Math.Sqrt(Math.Pow(m, 3) * n)) + (m * n) + Math.Pow(m, 2) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n) / m);
double y_ = (2.4 * Math.Abs(Math.Pow(x, 2) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b));

Console.WriteLine($"z1={z1},z2={z2},y={y_}");

