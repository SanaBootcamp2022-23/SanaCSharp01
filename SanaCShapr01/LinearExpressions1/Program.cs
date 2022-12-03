Console.WriteLine("LinearExpressions1");

double a;
double b;
double c;
double d;

Console.WriteLine("Input a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Input b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Input c");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Input d");
d = double.Parse(Console.ReadLine());

double x = (a + 2*b - c + d) / (c * d) + (a + b) / (c - d) - ((Math.Pow(a, 2) / Math.Pow(b, 2)));
Console.WriteLine("x");
Console.WriteLine(x);
double y = ((5 * (a + b)) * (c - d)) / ((0.5) * c) + ((Math.Pow(d, 2))) * ((((Math.Pow(a, 2))) - ((Math.Pow(b, 2)))) / (b - a));
Console.WriteLine("y");
Console.WriteLine(y);
double z = (((Math.Pow((Math.Pow(x, 2) - (2*x)), 3)) - (4 * (Math.Pow(x, 4) + 1))) * (1 - b)) / ((5 * a) + (3 * b));
Console.WriteLine("z");
Console.WriteLine(z);
double r = ((0.5 * a) + (0.75 * b) - (1.4)) / ((3 * c) + 1) + 1 / (a - c);
Console.WriteLine("r");
Console.WriteLine(r);
