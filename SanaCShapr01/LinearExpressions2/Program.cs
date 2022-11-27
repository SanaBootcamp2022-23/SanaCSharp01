using System.Linq.Expressions;

double a, b, x, m, n;
double expressionsR1, expressionsR2, expressionsY;

Console.WriteLine("Enter A:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter B:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter X:");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter M:");
m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter N:");
n = Convert.ToDouble(Console.ReadLine());


expressionsR1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n))/ (Math.Sqrt((Math.Pow(m, 3) * n)) + (n * m) + Math.Pow(m, 2) - m);
expressionsR2 = ((Math.Sqrt(m)-Math.Sqrt(n))/(m));
expressionsY = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + ((a - b) * Math.Pow(Math.Sin(a - b), 2)) + (Math.Pow(10, -2) * (x - b));
Console.WriteLine($"Expressions R1: {expressionsR1}\nExpressions R2: {expressionsR2}\nExpressions Y:{expressionsY}");
