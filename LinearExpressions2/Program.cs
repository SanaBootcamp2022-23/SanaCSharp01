using System;

namespace LinearExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 2
            double m, n, x, a, b, z1, z2, y;
            Console.Write("Введiть число M: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть число N: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть число X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть число A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть число B: ");
            b = Convert.ToInt32(Console.ReadLine());

            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b) + Math.Pow(10, -2) * (x - b);


            Console.WriteLine("Z1 = " + z1 + "\nZ2 = " + z2 + "\nY = " + y);
        }
    }
}
