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
            Console.WriteLine("Введіть ваші значення почергово:");
            a = double.Parse(Console.ReadLine()) ;
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            x = ((a + (2 * b) - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
            y = ((5 * (a + b) * (c - d) / (c / 2)) + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a))));
            z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 2) + 1) * (1 - b)) / ((5 * a) + (3 * b));
            r = (((a / 2) + 3 * (b / 4) - (7 / 5)) / (3 * c) + 1) + (1 / (a - c));
            Console.WriteLine("x = {0} \ny = {1} \nz = {2} \nr = {3}", Math.Round(x, 2), Math.Round(y, 2), Math.Round(z, 2), Math.Round(r, 2));
        }
    }
}