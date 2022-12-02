using System;

namespace LinearExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, m, n, x;
            a = GetDouble("a");
            b = GetDouble("b");
            m = GetDouble("m");
            n = GetDouble("n");
            x = GetDouble("x");

            double z1, z2, y;
            z1 = Math.Round(((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) /
                (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m), 3);
         
            z2 = Math.Round((Math.Sqrt(m) - Math.Sqrt(n) / m), 3);

            y = Math.Round(2.4 * Math.Abs((x * x + b) / a) + (a - b) *
                Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b), 3);

            Console.WriteLine($"\nz1 = {z1}\tz2 = {z2}\ty = {y}");
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
