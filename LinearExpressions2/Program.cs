using System;
using System.Text;
using static System.Math;


namespace LinearExpressions2

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

                double z1, z2, y, a, b, x, m, n;

                Console.Write("Enter m: ");
                m = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter n: ");
                n = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter b: ");
                b = Convert.ToDouble(Console.ReadLine());


                z1 = ((m - 1) * Sqrt(m) - (n - 1) * Sqrt(n)) / (Sqrt(Pow(m, 3) * n) + (n * m) + Pow(m, 2) - m);
                Console.WriteLine($"z1 = {z1}");

                z2 = (Sqrt(m) - Sqrt(n)) / m;
                Console.WriteLine($"z2 = {z2}");

                y = 2.4 * Abs((Pow(x, 2) + b) / a) + (a - b) * Pow(Sin(a - b), 2) + Pow(10, -2) * (x - b);
                Console.WriteLine($"y = {y}");

            }
        }
    }
}