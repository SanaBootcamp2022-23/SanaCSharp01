double a, b, c, d;

Console.WriteLine("Enter number 'а':");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number 'b':");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number 'c':");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number 'd':");
d = double.Parse(Console.ReadLine());

double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((Math.Pow(a, 2)) / Math.Pow(b, 2));
double y = ((5 * (a + b) * (c - d)) / ((1 / 2.0) * c)) + (Math.Pow(d,2)) * (Math.Pow(a,2) - Math.Pow(b,2))/(b-a);
double z = ((Math.Pow((Math.Pow(x,2) - 2 * x),3) - 4 * (Math.Pow(x,4) + 1)) * (1-b)) / (5 * a + 3 * b);
double r = (((1/2.0 * a) + 3/4.0*b - 7/5.0) / (3*c + 1)) + (1 / (a - c));

Console.WriteLine($"Result x = {x}");
Console.WriteLine($"Result y = {y}");
Console.WriteLine($"Result z = {z}");
Console.WriteLine($"Result r = {r}");