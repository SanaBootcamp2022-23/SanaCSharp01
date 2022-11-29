using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a, b, x, m, n, z1, z2, y;

double enternubmer(string name, out double nubmer)
{
    Console.Write($"Введiть число {name}: ");
    while (!double.TryParse(Console.ReadLine(), out nubmer))
    {
        Console.Write($"Невірно введенно число {name}, введіть ще раз число {name}: ");
    }
    return nubmer;
}
a = enternubmer("a", out a);
b = enternubmer("b", out b);
x = enternubmer("x", out x);
m = enternubmer("m", out m);
n = enternubmer("n", out n);

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.Write($"Результат обчислення z1 = {z1}\nРезультат обчислення z2 = {z2}\nРезультат обчислення y = {y}");
