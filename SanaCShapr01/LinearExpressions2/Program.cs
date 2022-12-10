using System.Text;

namespace LinearExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double m, n, a, b, x;
            double z1, z2, y;

            Console.WriteLine("Введіть значення m ");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення n ");
            n = double.Parse(Console.ReadLine());

            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

            Console.WriteLine("Введіть значення a ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення b ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення x ");
            x = double.Parse(Console.ReadLine());
            
            y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

            Console.WriteLine($"z1 = {z1}\nz2 = {z2}\ny = {y}");
        }
    }
}