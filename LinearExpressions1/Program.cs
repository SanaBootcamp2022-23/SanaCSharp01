double a, b, c, d;
Console.Write("Enter the value a: ");
a = double.Parse(Console.ReadLine());

Console.Write("Enter the value b: ");
b = double.Parse(Console.ReadLine());

Console.Write("Enter the value c: ");
c = double.Parse(Console.ReadLine());

Console.Write("Enter the value d: ");
d = double.Parse(Console.ReadLine());

Console.Write("\n");

double x, y, z, r;
x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (Math.Pow(a, 2)) / (Math.Pow(b, 2));
Console.Write("1) Example x = {0}\n\n", x);

y = (5 * (a + b) * (c - d) / 1 / 2 * c) + ((d * d) * (a * a - b * b) / (b - a));
Console.Write("2) Example y = {0}\n\n", y);

z = ((Math.Pow((x * x - 2 * x), 3) - 4 * (x * x * x * x + 1)) * (1 - b)) / (5 * a + 3 * b);
Console.Write("3) Example z = {0}\n\n", z);

r = (((1 / 2) + (3 / 4) * b - (7 / 5)) / 3 * c + 1) + (1 / (a - c));
Console.Write("4) Example r = {0}\n\n", r);