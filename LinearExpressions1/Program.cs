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

            double a, b, c, d, x, y, z, r;

            // вводимо числа з клавіатури 

            Console.WriteLine("Введіть значення a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення c:");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення d:");
            d = double.Parse(Console.ReadLine());

            // виводимо введені числа на екран

            Console.WriteLine("Значення a = {0}", a);
            Console.WriteLine("Значення b = {0}", b);
            Console.WriteLine("Значення c = {0}", c);
            Console.WriteLine("Значення d = {0}", d);

            // виконуємо задані обчислення

            x = ((a + (2 * b) - c + d) / (c * d)) + ((a + b) / (c - d)) - ((Math.Pow(a, 2)) / (Math.Pow(b, 2)));
            y = (5 * (a + b) * (c - d)) / (0.5 * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2)) - (Math.Pow(b, 2))) / (b - a);
            z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
            r = ((((1 / 2) * a) + ((3 / 4) * b) - (7 / 5)) / (3 * c + 1)) + (1 / (a - c)); ;
            
            // вивід результатів обчислень

            Console.WriteLine("Результат x = {0}", x);
            Console.WriteLine("Результат y = {0}", y);
            Console.WriteLine("Результат z = {0}", z);
            Console.WriteLine("Результат r = {0}", r);

        }
    }
}

