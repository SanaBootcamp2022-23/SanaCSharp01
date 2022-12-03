Console.WriteLine("linearExpressions2");

double m;
double n;
double a;
double b;
double x;

Console.WriteLine("Input m");
m = double.Parse(Console.ReadLine());
Console.WriteLine("Input n");
n = double.Parse(Console.ReadLine());
Console.WriteLine("Input a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Input b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Input x");
x = double.Parse(Console.ReadLine());

double z1 = ((m - 1)*Math.Sqrt(m) - (n -1)*Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3)*n) + n * m + Math.Pow(m, 2) - m);
Console.WriteLine("z1");
Console.WriteLine(z1);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine("z");
Console.WriteLine(z2);
double y = (2.4 * Math.Abs((Math.Pow(x, 2) + b) / a)) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine("y");
Console.WriteLine(y);