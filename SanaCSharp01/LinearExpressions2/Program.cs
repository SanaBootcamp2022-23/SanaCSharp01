using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double n, m, a, b, x, z1, z2, y;

Console.Write("Введіть змінну n:");
n = double.Parse(Console.ReadLine());

Console.Write("Введіть змінну m:");
m = double.Parse(Console.ReadLine());

Console.Write("Введіть змінну x:");
x = double.Parse(Console.ReadLine());

Console.Write("Введіть змінну a:");
a = double.Parse(Console.ReadLine());

Console.Write("Введіть змінну b:");
b = double.Parse(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("\nЗначення z1:{0}\nЗначення z2:{1}\nЗначення y:{2}", z1, z2, y);