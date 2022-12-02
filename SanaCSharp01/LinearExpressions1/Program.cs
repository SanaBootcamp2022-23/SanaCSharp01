using System;

namespace LinearExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = GetDouble("a");
            b = GetDouble("b");
            c = GetDouble("c");
            d = GetDouble("d");

            double x, y, z, r;
            x = Math.Round((a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b), 3);
            y = Math.Round((5 * (a + b) * (c - d)) / (c / 2) + d * d * ((a * a) - (b * b)) / (b - a), 3);
            z = Math.Round(((Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b), 3);
            r = Math.Round((a / 2 + (3.0 / 4) * b - 7.0 / 5) / (3 * c + 1) + 1 / (a - c), 3);

            Console.WriteLine($"\nx = {x}\ty = {y}\tz = {z}\tr = {r}\t");
        }

        public static double GetDouble(string info)
        {
            bool check = false;
            double result = 0;

            while (!check)
            {
                Console.Write($"Enter {info}: ");
                check = double.TryParse(Console.ReadLine(), out result);
                if (!check) Console.WriteLine("Input error! Try again!");
            }

            return result;
        }
    }
}
