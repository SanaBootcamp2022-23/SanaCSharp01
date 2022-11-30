double a, b, c, d, x, y, z, r;

Console.WriteLine("Enter a:");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Enter b:");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Enter c:");
c = double.Parse(Console.ReadLine());

Console.WriteLine("Enter d:");
d = double.Parse(Console.ReadLine());

//Expressions
x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (Math.Pow(a, 2) / Math.Pow(b, 2));

y = (5 * (a + b) * (c - d)) / (0.5 * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));

z = ((Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);

r = (0.5 * a + 0.75 * b - 1.4) / (3 * c + 1) + 1 / (a - c);

Console.WriteLine($"\nX = {x}");
Console.WriteLine($"Y = {y}");
Console.WriteLine($"Z = {z}");
Console.WriteLine($"R = {r}");











