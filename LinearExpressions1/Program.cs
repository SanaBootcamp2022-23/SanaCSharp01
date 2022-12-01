using System;
using System.Text;
using static System.Math;


namespace LinearExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberDecimalSeparator = ".";
                System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
                Console.OutputEncoding = Encoding.Unicode;
                Console.InputEncoding = Encoding.Unicode;

                double a, b, c, d, x, y, z, r;

                Console.Write("Enter a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter c: ");
                c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter d: ");
                d = Convert.ToDouble(Console.ReadLine());

                x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - Pow(a, 2) / Pow(b, 2);
                Console.WriteLine($"х = {x}");

                y = (5 * (a + b) * (c - d)) / ((1.0 / 2.0) * c) + (Pow(d, 2) * ((Pow(a, 2) - Pow(b, 2)) / (b - a)));
                Console.WriteLine($"y = {y}");

                z = (Pow(Pow(x, 2) - 2 * x, 3) - 4 * (Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
                Console.WriteLine($"z = {z}");

                r = ((((1.0 / 2.0) * a) + ((3.0 / 4.0) * b) - (7.0 / 5.0)) / (3 * c + 1)) + (1 / (a - c));
                Console.WriteLine($"r = {r}");
            }
        }
    }
}