// See https://aka.ms/new-console-template for more information

double a, b, c, d, x, y, z, r;

Console.Write("Enter value a: ");
a = double.Parse(Console.ReadLine());

Console.Write("Enter value b: ");
b = double.Parse(Console.ReadLine());

Console.Write("Enter value c: ");
c = double.Parse(Console.ReadLine());

Console.Write("Enter value d: ");
d = double.Parse(Console.ReadLine());



x = ((a + (2 * b) - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
Console.WriteLine("x = {0}", x);

y = ((5 * (a + b) * (c - d))
                / (0.5 * c)) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) 
                                                                        / (b - a));
Console.WriteLine("y = {0}", y);

z = ((Math.Pow(Math.Pow(x, 2) - (2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b))
     / ((5 * a) + (3 * b));
Console.WriteLine("z = {0:F3}", z);

r = (((0.5 * a) + (0.75 * b) - 1.4)
                     / ((3 * c) + 1)) + 1 / (a - c);
Console.WriteLine("r = {0:F3}", r);
