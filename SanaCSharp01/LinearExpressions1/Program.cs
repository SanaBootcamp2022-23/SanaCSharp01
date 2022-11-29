using System;

namespace LinearExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;

            Console.WriteLine("Введіть a b c d\n");

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            double x, y, z, r;

            x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);

            y = 5 * (a + b) * (c - d) / (0.5f * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);

            z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b))
                / (5 * a + 3 * b);

            r = (0.5f * a + 0.75f * b - 7.0 / 5.0) / (3 * c + 1) + 1 / (a - c);

            Console.WriteLine($"x = {x}\ny = {y}\nz = {z}\nr = {r}");

        }
    }
}
