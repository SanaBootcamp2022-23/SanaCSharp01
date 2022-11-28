
internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, x, m, n, z,z2, y;
        Console.Write("A ");
        a = double.Parse(Console.ReadLine());
        Console.Write("B ");
        b = double.Parse(Console.ReadLine());
        Console.Write("X ");
        x = double.Parse(Console.ReadLine());
        Console.Write("M ");
        m = double.Parse(Console.ReadLine());
        Console.Write("N ");
        n = double.Parse(Console.ReadLine());
        if (m != 0 && n != 0 && a != 0){
            z = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / ((Math.Sqrt(Math.Pow(m, 3) * n) + (n * m) + (m * m) - m));
            Console.WriteLine($"Z {z}");
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine($"Z {z2}");
            y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine($"Z {y}");
        }
        else{
            Console.WriteLine("Error! Number = 0");
        }
    }
}