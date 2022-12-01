using System;

namespace LinearExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeVariable("m", out double m);
            InitializeVariable("n", out double n);

            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m),
                   z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

            Console.WriteLine($"\nz1 = {z1}\nz2 = {z2}\n");

            InitializeVariable("x", out double x);
            InitializeVariable("a", out double a);
            InitializeVariable("b", out double b);

            double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

            Console.WriteLine($"\n y = {y}");
        }

        static void InitializeVariable(string variableName, out double variable)
        {
            Console.Write($"Enter a double variable {variableName}: ");
            variable = double.Parse(Console.ReadLine());
        }
    }
}
