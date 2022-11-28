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
            ReadDoubleNumberFromConsole("m", out m);
            ReadDoubleNumberFromConsole("n", out n);
            ReadDoubleNumberFromConsole("a", out a);
            ReadDoubleNumberFromConsole("b", out b);
            ReadDoubleNumberFromConsole("x", out x);
            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            y = (2.4 * Math.Abs((x * x + b) / a)) + ((a - b) * Math.Pow(Math.Sin(a - b), 2)) + (Math.Pow(10, -2) * (x - b));
            Console.WriteLine($"Результат обчислення першого виразу, 'z1' = {z1}");
            Console.WriteLine($"Результат обчислення другого виразу, 'z2' = {z2}");
            Console.WriteLine($"Результат обчислення третього виразу, 'y' = {y}");
        }
        private static void ReadDoubleNumberFromConsole(string varName, out double number)
        {
            bool check;
            do
            {
                Console.Write($"Введіть число '{varName}': ");
                check = double.TryParse(Console.ReadLine(), out number);
                if (!check)
                    Console.WriteLine("Ви помилилися при введенні. Спробуйте ще!");
            } while (!check);
        }
    }
}