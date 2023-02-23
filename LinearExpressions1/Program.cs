using System;

namespace LinearExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1
            double a, b, c, d, x, y, z, r;
                Console.Write("Введiть число A: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введiть число B: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введiть число C: ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введiть число D: ");
                d = Convert.ToInt32(Console.ReadLine());

            x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);

            y = (5 * (a + b) * (c - d)) / (0.5 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2) / (b - a));

            z = (Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a - 3 * b);

            r = ((1.0 / 2.0) * a + (3.0 / 4.0) * b - 7.0 / 5.0) / (3 * c + 1) + 1 / (a - c);

            Console.WriteLine("X = " + x + "\nY = " + y + "\nZ = " + z + "\nR = " + r);
        }
    }
}
