using System.Text;

namespace LinearExpressions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a, b, c, d, x, y, z, r;
            ReadDoubleNumberFromConsole("a", out a);
            ReadDoubleNumberFromConsole("b", out b);
            ReadDoubleNumberFromConsole("c", out c);
            ReadDoubleNumberFromConsole("d", out d);
            x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
            y = ((5 * (a + b) * (c - d)) / ((1 / 2.0) * c)) + (d * d) * ((a * a - b * b) / (b - a));
            z = ((Math.Pow((x * x - 2 * x), 3) - (4 * (Math.Pow(x, 4) + 1))) * (1 - b)) / (5 * a + 3 * b);
            r = (((1 / 2.0) * a + (3 / 4.0) * b - (7 / 5.0)) / (3 * c + 1)) + (1 / (a - c));
            Console.WriteLine($"Результат обчислення першого виразу, 'x' = {x}");
            Console.WriteLine($"Результат обчислення другого виразу, 'y' = {y}");
            Console.WriteLine($"Результат обчислення третього виразу, 'z' = {z}");
            Console.WriteLine($"Результат обчислення четвертого виразу, 'r' = {r}");
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