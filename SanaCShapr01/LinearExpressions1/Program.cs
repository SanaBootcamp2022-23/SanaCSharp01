Console.WriteLine("Введiть занчення змiнних для виразу:");
double a, b, c, d;
Console.Write("a: "); a = double.Parse(Console.ReadLine());
Console.Write("b: "); b = double.Parse(Console.ReadLine());
Console.Write("c: "); c = double.Parse(Console.ReadLine());
Console.Write("d: "); d = double.Parse(Console.ReadLine());

double x = 0, y = 0, z = 0, r = 0;


if (c * d == 0 || c - d == 0 || b* b == 0) Console.WriteLine("Помилка");
else
{
    x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) + (a * a) / (b * b);
    Console.WriteLine($"Результат виразу x = {x}");
}


if (1 / 2.0 * c == 0 || b - a == 0) Console.WriteLine("Помилка");
else
{
    y = (5 * (a + b) * (c - d)) / (1.0 / 2 * c) + (d * d * (a * a - b * b)) / (b - a);
    Console.WriteLine($"Результат виразу y = {y}");
}


if (5 * a + 3 * b == 0) Console.WriteLine("Помилка");
else
{
    z = ((Math.Pow((x * x - 2 * x), 3) - 4 * (x * x * x * x + 1)) * (1 - b)) / (5 * a + 3 * b);
    Console.WriteLine($"Результат виразу z = {z}");
}


if (3 * c + 1 == 0 ||  a - c == 0) Console.WriteLine("Помилка");
else
{
    r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1 / (a - c);
    Console.WriteLine($"Результат виразу r = {r}");
}