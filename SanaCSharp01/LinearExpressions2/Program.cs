namespace LinearExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m, n;
            Console.Write("Enter value of 'm': ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of 'n': ");
            n = Convert.ToDouble(Console.ReadLine());

            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
            Console.WriteLine($"z1={z1}");
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine($"z2={z2}");

            double x, a, b;
            Console.Write("Enter value of 'x': ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of 'a': ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of 'b': ");
            b = Convert.ToDouble(Console.ReadLine());

            double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + (x - b) / 100;
            Console.WriteLine($"y={y}");
        }
    }
}