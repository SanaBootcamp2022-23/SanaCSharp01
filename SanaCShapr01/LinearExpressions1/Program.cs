Console.WriteLine("Input number a");
double a;
a = double.Parse(Console.ReadLine());

Console.WriteLine("Input number b");
double b;
b = double.Parse(Console.ReadLine());

Console.WriteLine("Input number c");
double c;
c = double.Parse(Console.ReadLine());

Console.WriteLine("Input number d");
double d;
d = double.Parse(Console.ReadLine());

double x;
x = ((a + 2.0 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
Console.WriteLine($"Result of calculating x: {x}");

double y;
y = ((5.0 * (a +  b) * (c - d)) / (1.0 / 2.0 * c)) + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)));
Console.WriteLine($"Result of calculating y: {y}");

double z;
z = ((Math.Pow((Math.Pow(x, 2) - 2.0 * x), 3) - 4.0 * (Math.Pow(x, 4) + 1.0)) * (1.0 - b)) / (5.0 * a + 3.0 * b);
Console.WriteLine($"Result of calculating z: {z}");

double r; 
r = ((1.0 / 2.0 * a + 3.0 / 4.0 * b - 7.0 / 5.0) / (3.0 * c + 1.0)) + (1.0 / (a - c));
Console.WriteLine($"Result of calculating r: {r}");


