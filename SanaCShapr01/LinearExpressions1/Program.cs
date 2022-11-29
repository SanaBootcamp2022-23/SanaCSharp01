using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a, b, c, d, x, y, z, r;
double enternubmer(string name, out double nubmer)
{
    Console.Write($"Введiть число {name} ");
    while (!double.TryParse(Console.ReadLine(), out nubmer))
    {
        Console.Write($"Невірно введенно число {name}, введіть ще раз число {name}: ");
    }
    return nubmer;
}

a = enternubmer("a", out a);
b = enternubmer("b", out b);
c = enternubmer("c", out c);
d = enternubmer("d", out d);

x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (a * a / (b * b));
y = (5 * (a + b) * (c - d)) / (1.0 / 2.0 * c) + (d * d * ((a * a - b * b) / (b - a)));
z = ((Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
r = (1.0 / 2.0 * a + 3.0 / 4.0 * b - 7.0 / 5.0) / (3 * c + 1) + 1 / (a - c);

Console.Write($"Результат обчислення x = {x}\nРезультат обчислення y = {y}\nРезультат обчислення z = {z}\nРезультат обчислення r = {r}");