namespace myApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            double m, n, z1, z2, y, x, a, b;
            Console.WriteLine("Введіть число m: ");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введітть число n: ");
            n = double.Parse(Console.ReadLine());

            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
            Console.WriteLine($"z1 = {z1}");
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine($"z2 = {z2}");

            Console.WriteLine("Чудова робота! \nВведіть число а: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введітть число b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введітть число x: ");
            x = double.Parse(Console.ReadLine());

            y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine($"y = {y}");
        }
    }
}
