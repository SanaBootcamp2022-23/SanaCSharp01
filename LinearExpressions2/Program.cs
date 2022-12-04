using System;
using System.Text;

namespace prakt3
{
    class Program
    {
        static void Main()
        {
            // вмикаємо підримку укр. абетки

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //оголошуємо змінні типу double

            double a, b, m, n, x, y, z1, z2;

            // вводимо числа з клавіатури 

            Console.WriteLine("Введіть значення a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення n:");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення m:");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення x:");
            x = double.Parse(Console.ReadLine());

            // виводимо введені числа на екран

            Console.WriteLine("Значення a = {0}", a);
            Console.WriteLine("Значення b = {0}", b);
            Console.WriteLine("Значення n = {0}", n);
            Console.WriteLine("Значення m = {0}", m);
            Console.WriteLine("Значення x = {0}", x);

            // виконуємо задані обчислення

            z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3) * n) + (n * m) + Math.Pow(m, 2) - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            y = (2.4 * ((Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b))) * Math.Pow(Math.Sin(a - b), 2)) + (Math.Pow(10, -2) * (x - b));

            Console.WriteLine("Результат z1 = {0}", z1);
            Console.WriteLine("Результат z2 = {0}", z2);
            Console.WriteLine("Результат y = {0}", y);
        }
    }
}
