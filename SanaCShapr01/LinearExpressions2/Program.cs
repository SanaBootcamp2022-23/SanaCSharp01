// See https://aka.ms/new-console-template for more information


Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Write("Введіть число а: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть число b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть число m: ");
double m = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть число n: ");
double n = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть число x: ");
double x = Convert.ToDouble(Console.ReadLine());


double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);

double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

double y = 2.4 * Math.Abs((x * x + b) / a) + (a + b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);


Console.WriteLine("Результат: ");

Console.Write($"z1 = {z1}  ");

Console.Write($"z2 = {z2}  ");

Console.Write($"y = {y}  ");

Console.ReadKey();