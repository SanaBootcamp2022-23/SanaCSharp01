using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter values: ");
            Console.Write("a: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = int.Parse(Console.ReadLine());
            Console.Write("d: ");
            double d = int.Parse(Console.ReadLine());

            double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
            Console.WriteLine($"x: {x}");
            double y = (5 * (a + b) * (c - d)) / (0.5 * c) + (d * d) * ((a * a) - (b * b)) / (b - a);
            Console.WriteLine($"y: {y}");
            double z = ((Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
            Console.WriteLine($"z: {z}");
            double r = (0.5 * a + 0.75 * b - 1.4) / (3 * c + 1) + 1 / (a - c);
            Console.WriteLine($"r: {r}");
        }
    }
}