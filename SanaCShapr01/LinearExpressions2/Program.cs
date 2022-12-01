using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a, b, x, m, n,z1,z2,y;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.WriteLine("Sana BootCamp Lab 3.\nВиконав: Радченко Д.В\n");
            do
            {
                Console.Write("Введіть дробове значення a = ");
                if (double.TryParse(Console.ReadLine(), out a)) break;
                else { Console.WriteLine(" Error while inputing,pls rewrite correctly"); }
            } while (true);
            do
            {
                Console.Write("Введіть дробове значення b = ");
                if (double.TryParse(Console.ReadLine(), out b)) break;
                else { Console.WriteLine(" Error while inputing,pls rewrite correctly"); }
            }
            while (true);
            do
            {
                Console.Write("Введіть дробове значення x = ");
                if (double.TryParse(Console.ReadLine(), out x)) break;
                else { Console.WriteLine(" Error while inputing,pls rewrite correctly"); }
            } while (true);
            do
            {
                Console.Write("Введіть дробове значення m = ");
                if (double.TryParse(Console.ReadLine(), out m)) break;
                else { Console.WriteLine(" Error while inputing,pls rewrite correctly"); }
            }
            while (true);
            do
            {
                Console.Write("Введіть дробове значення n = ");
                if (double.TryParse(Console.ReadLine(), out n)) break;
                else { Console.WriteLine(" Error while inputing,pls rewrite correctly"); }
            }
            while (true);


            Console.Write("a ={0}", a);
            Console.Write("\nb ={0}", b);
            Console.Write("\nm ={0}", m);
            Console.Write("\nn ={0}", n);
            Console.Write("\nx ={0}", x);

            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + (n * m) + (Math.Pow(m, 2) - m));

            Console.Write($"\nВираз Z1 дорівнює - {z1}");

            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

            Console.Write($"\nВираз Z2 дорівнює - {z2}");

            y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

            Console.Write($"\nВираз Y дорівнює - {y}");

            Console.ReadKey();
        }
    }
}
