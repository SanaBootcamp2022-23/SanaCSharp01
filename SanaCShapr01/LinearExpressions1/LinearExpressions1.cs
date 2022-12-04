using System;

namespace LinearExpressions1
{
    class LinearExpressions1
    {
        static void Main(string[] args)
        {
            // Я Думав як краще було би зробить, щоб було потрібно вводити : a,b,c,d 1 раз
            // та воно давало зразу відповідь до 4 рівнянь,чи щоб під кожне із рівнянь
            // було потрібно повторно ввести змінні, та вирішив зробити так, сподіваюсь 
            // що це не буде зараховано як не правильно
            double a, b, c, d, x, z, r, y, z1;
            Console.WriteLine("Fits expression");
            Console.Write("a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = "); c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d = "); d = Convert.ToInt32(Console.ReadLine());
            x = ((a + (2 * b) - c + d) / c * d) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
            Console.WriteLine("Answer x = " + Math.Round(x, 2));
            Console.WriteLine("Second expression");
            Console.Write("a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = "); c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d = "); d = Convert.ToInt32(Console.ReadLine());
            y = (5 * (a + b) * (c - d) / ((1.0 / 2.0) * c)) + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2))) / (b - a));
            Console.WriteLine("Answer y = " + Math.Round(y, 2));
            Console.WriteLine("Third expression");
            Console.Write("a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = "); b = Convert.ToInt32(Console.ReadLine());
            z1 = Math.Pow(x, 2) - 2 * x;
            z = ((Math.Pow(z1, 3) - 4 * (Math.Pow(x, 4) + 1))) * (1 - b) / (5 * a + 3 * b);
            Console.WriteLine("Answer z = " + Math.Round(z, 2));
            Console.WriteLine("Fourth expression");
            Console.Write("a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = "); c = Convert.ToInt32(Console.ReadLine());
            r = (((1.0 / 2.0) * a) + ((3.0 / 4.0) * b) - (7.0 / 5.0)) / (3 * c + 1) + (1 / (a - c));
            Console.WriteLine("Answer r = " + Math.Round(r, 5));
        }
    }
}
