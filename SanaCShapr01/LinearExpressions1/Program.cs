using System;

namespace LinearExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeVariable("a", out double a);
            InitializeVariable("b", out double b);
            InitializeVariable("c", out double c);
            InitializeVariable("d", out double d);

            double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2)),
                   y = 5 * (a + b) * (c - d) / (0.5 * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)),
                   z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b),
                   r = (0.5 * a + (3.0 / 4.0 * b) - (7.0 / 5.0)) / (3.0 * c + 1) + (1.0 / (a - c));

            Console.WriteLine($"\nx = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");
            Console.WriteLine($"r = {r}");
        }
        static void InitializeVariable(string variableName, out double variable)
        {
            Console.Write($"Enter a double variable {variableName}: ");
            variable = double.Parse(Console.ReadLine());
        }
    }
}
