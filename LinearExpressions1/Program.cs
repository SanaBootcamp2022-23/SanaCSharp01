// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double a, b, c, d, x, y, z, r;
Console.WriteLine("Введіть змінну a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть змінну b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть змінну c:");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть змінну d:");
d = double.Parse(Console.ReadLine());
x = (a + 2* b - c + d) / (c * d) + (a + b) / (c - d) - a * a / (b * b);
Console.WriteLine(x);
y = (5 * (a + b) * (c - d)) / (0.5 * c) + d * d * (a * a - b * b) / (b - a);
Console.WriteLine(y);
z = ((Math.Pow(x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine(z);
r = (0.5 * a + 3 / 4 * b - 7 / 5) / (3 * c + 1) + 1 /(a - c); 
Console.WriteLine(r);