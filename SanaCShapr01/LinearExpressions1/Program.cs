

Console.WriteLine("Enter a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter c");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter d");
double d = Convert.ToDouble(Console.ReadLine());

double x, y, z, r;

x = ((a + 2 * c - c + d) / c * d) + ((a + b) / (c - d)) - ((a * a) / (b * b));
y = ((5 * (a + b) * (c - d)) / (1.0 / 2 * c))+(d*d*((a*a-b*b)/(b-a)));
z = ((x * x - 2 * x * x) * (x * x - 2 * x * x) * (x * x - 2 * x * x) - 4 * (x * x * x * x + 1) * (1 - b) / (5 * a + 3 * b));
r = (((1.0 / 2 * a) +(3.0/4*b)-7.0/5) / (3*c+1))+((1.0)/(a-c));


Console.WriteLine("x = {0}", x);
Console.WriteLine("y = {0}", y);
Console.WriteLine("z = {0}", z);
Console.WriteLine("r = {0}", r);
