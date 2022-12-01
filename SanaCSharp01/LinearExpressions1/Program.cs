// See https://aka.ms/new-console-template for more information


double a, b, c, d, x, y, z, r;
bool tof;
Console.Write("Введіть значення а: ");
a = double.Parse(Console.ReadLine());
Console.Write("Введіть значення b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Введіть значення c: ");
c = double.Parse(Console.ReadLine());
Console.Write("Введіть значення d: ");
d = double.Parse(Console.ReadLine());

x = Math.Round(((a + 2 * b - c + d)/(c*d)) + ((a+b)/(c-d)) - (Math.Pow(a, 2)/Math.Pow(b,2)),2);

y = Math.Round((5 * (a + b) * (c - d) / (c / 2)) + Math.Pow(d,2) * (Math.Pow(a,2) - Math.Pow(b, 2))/(a - b),2);

z = Math.Round((Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - (4 * (Math.Pow(x, 4) + 1) * (1 - b)))/ (5*a - 3*b),2);

r = Math.Round((a/2 + 3 * b / 4 - 7.0/ 5)/(3*c+1) + 1/(a - c),2);

Console.WriteLine($"x = {x}\ny = {y}\nz = {z}\nr = {r}");