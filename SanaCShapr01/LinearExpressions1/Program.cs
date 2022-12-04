using System;

namespace linearExpressions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("Entyer the value of a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entyer the value of a: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Entyer the value of a: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Entyer the value of a: ");
            d = double.Parse(Console.ReadLine());

            double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
            Console.WriteLine($"X = {x}");
            double y = 10 * (a + b) * (c - d) / c + d * d * (a * a - b * b) / (b - a);
            Console.WriteLine($"Y = {y}");
            double z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
            Console.WriteLine($"Z = {z}");
            double r = (0.5 * a + (3 / 4.0) * b - 7 / 5.0) / (3 * c + 1) + 1 / (a - c);
            Console.WriteLine($"R = {r}");

        }
    }
}