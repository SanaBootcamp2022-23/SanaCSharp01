using System;

namespace LinearExpressions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Input d: ");
            double d = double.Parse(Console.ReadLine());

            double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
            Console.WriteLine($"x = {x}");
            double y = 5 * (a + b) * (c - d) / (1.0 / 2 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
            Console.WriteLine($"y = {y}");
            double z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
            Console.WriteLine($"z = {z}");
            double r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1.0 / (a - c);
            Console.WriteLine($"r = {r}");
        }
    }
}
