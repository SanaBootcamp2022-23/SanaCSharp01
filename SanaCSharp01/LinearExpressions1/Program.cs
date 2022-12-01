using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a, b, c, d, x, y, z, r;

Console.Write("Введіть змінну а:");
a = double.Parse(Console.ReadLine());

Console.Write("Введіть змінну b:");
b = double.Parse(Console.ReadLine());

Console.Write("Введіть змінну c:");
c = double.Parse(Console.ReadLine());

Console.Write("Введіть змінну d:");
d = double.Parse(Console.ReadLine());

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);

y = (5 * (a + b) * (c - d) / (1 / 2.0 * c)) + (d * d * (a * a - b * b) / (b - a));

z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);

r = (1 / 2.0 * a + 3 / 4.0 * b - 7 / 5.0) / (3 * c + 1) + 1 / (a - c);

Console.WriteLine("\nЗначення х:{0}\nЗначення y:{1}\nЗначення z:{2}\nЗначення r:{3}", x, y, z, r);