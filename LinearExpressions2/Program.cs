
Console.WriteLine("Enter m:");
double m = double.Parse(Console.ReadLine());
Console.WriteLine("Enter n:");
double n = double.Parse(Console.ReadLine());

double z1 = ((m-1) * Math.Sqrt(m) - (n-1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m,3) * n) + n*m + m*m - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"z1 = {z1}\nz2 = {z2}");

Console.WriteLine("Enter a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter x:");
double x = double.Parse(Console.ReadLine());

double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + 0.01 * (x - b);
Console.WriteLine($"y = {y}");