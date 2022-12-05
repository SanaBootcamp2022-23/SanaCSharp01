using System.Text;

namespace LinearExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double m, n, z1, z2, y, x, a, b;

            Console.Write($"Введіть число m: ");
            m = double.Parse(Console.ReadLine());
            Console.Write($"Введіть число n: ");
            n = double.Parse(Console.ReadLine());
            Console.Write($"Введіть число a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write($"Введіть число b: ");
            b = double.Parse(Console.ReadLine()); 
            Console.Write($"Введіть число x: ");
            x = double.Parse(Console.ReadLine());

            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            y = (2.4 * Math.Abs((x * x + b) / a)) + ((a - b) * Math.Pow(Math.Sin(a - b), 2)) + (Math.Pow(10, -2) * (x - b));

            Console.WriteLine($"Результат обчислення першого виразу, 'z1' = {z1}");
            Console.WriteLine($"Результат обчислення другого виразу, 'z2' = {z2}");
            Console.WriteLine($"Результат обчислення третього виразу, 'y' = {y}");
        }
    }
}