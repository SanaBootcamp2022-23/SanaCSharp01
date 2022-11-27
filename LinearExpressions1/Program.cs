Console.WriteLine("Enter the four numbers - a, b, c ,d.");
double a, b, c, d;
Console.Write("Enter the \'a\': ");
if (!double.TryParse(Console.ReadLine(), out a)) return;
Console.Write("Enter the \'b\': ");
if (!double.TryParse(Console.ReadLine(), out b)) return;
Console.Write("Enter the \'c\': ");
if (!double.TryParse(Console.ReadLine(), out c)) return;
Console.Write("Enter the \'d\': ");
if (!double.TryParse(Console.ReadLine(), out d)) return;
Console.WriteLine($"You enter a={a}, b={b}, c={c}, d={d}.");
if (c != 0 && d != 0 && c != d && b != 0 && b != a && a != c && c != 1 / 3)
{
    double x, y, z, r;
    x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
    y = (5 * (a + b) * (c - d)) / (1 / 2 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
    z = ((Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
    r = (1 / 2 * a + 3 / 4 * b - 7 / 5) / (3 * c + 1) + 1 / (a - c);
    Console.Write($"1. x = {x}\n" +
        $"2. y = {y}\n" +
        $"3. z = {z}\n" +
        $"4. r = {r}\n");
}
else
    Console.WriteLine("Incorect numbers");
