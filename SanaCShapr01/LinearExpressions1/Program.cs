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
            double a, b, c, d,x,y,z,r;
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
                Console.Write("Введіть дробове значення c = ");
                if (double.TryParse(Console.ReadLine(), out c)) break;
                else { Console.WriteLine(" Error while inputing,pls rewrite correctly"); }
            } while (true); 
            do
            {
                Console.Write("Введіть дробове значення d = ");
                if (double.TryParse(Console.ReadLine(), out d)) break;
                else { Console.WriteLine(" Error while inputing,pls rewrite correctly"); }
            } while (true);

            Console.Write("a ={0}", a);
            Console.Write("\nb ={0}", b);
            Console.Write("\nc ={0}", c);
            Console.Write("\nd ={0}", d);

            x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));

            Console.Write($"\nВираз Х дорівнює - {x}");

            y = ((5 * (a + b) * (c - d)) / ((1 / 2.0) * c)) + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2))/(b - a)));

            Console.Write($"\nВираз Y дорівнює - {y}");

            z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);

            Console.Write($"\nВираз Z дорівнює - {z}");

            r = ((((1 / 2.0) * a) + ((3 / 4.0) * b) - (7 / 5.0)) / (3 * c + 1)) + (1.0 / (a - c));

            Console.Write($"\nВираз R дорівнює - {r}");


            Console.ReadKey();
        }
    }
}
