using System;

namespace LinearExpressions2
{
    class LinearExpressions2
    {
        static void Main(string[] args)
        {
            double z1, z2, m, n, y, a, b, x, q, w, e, r, t,cons=2.4,ui,wer;
            Console.WriteLine("Fits expression");
            Console.Write("m = "); m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = "); n = Convert.ToInt32(Console.ReadLine());
            q = (m - 1) * Math.Sqrt(m); w = (n - 1) * Math.Sqrt(n); t = Math.Pow(n, 3) * n; e = Math.Sqrt(t) / (n * m) / (Math.Pow(m, 2)) - m;
            z1 = (q - w) / e ;
            Console.WriteLine("Answer z1 = " + Math.Round(z1, 2));
            Console.WriteLine("Second expression");
            Console.Write("m = "); m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = "); n = Convert.ToInt32(Console.ReadLine());
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine("Answer z2 = " + Math.Round(z2, 2));
            Console.WriteLine("Third expression");
            Console.Write("a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = "); x = Convert.ToInt32(Console.ReadLine());
            r = (a - b);double z = Math.Abs((Math.Pow(x, 2) + b) / a); ui = (x - b);wer = Math.Pow(Math.Sin(r), 2);
            y = (cons * z) + (r * wer) + (Math.Pow(10, -2) * ui);
            Console.WriteLine("Answer y = " + Math.Round(y, 2));
        }
    }
}
