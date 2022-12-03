// See https://aka.ms/new-console-template for more information
double m, n;
Console.WriteLine("Enter variable m:");
m = double.Parse(Console.ReadLine());
Console.WriteLine("Enter variable n:");
n = double.Parse(Console.ReadLine());
double z1 = ((m-1)*Math.Sqrt(m)-(n-1)*Math.Sqrt(n))/((Math.Sqrt(Math.Pow(m, 3)*n))+n*m+Math.Pow(m,2)-m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"Result z1 = {z1}");
Console.WriteLine($"Result z2 = {z2}");
double a, b, x;
Console.WriteLine("Enter variable a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter variable b:");
b= double.Parse(Console.ReadLine());
Console.WriteLine("Enter variable x:");
x = double.Parse(Console.ReadLine());
double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"Result y = {y}");