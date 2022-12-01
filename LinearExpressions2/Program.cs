class Program
{
    static void Main(string[] args)
    {

        Console.Write("m = ");

        double m = Convert.ToDouble(Console.ReadLine());

        Console.Write("n = ");

        double n = Convert.ToDouble(Console.ReadLine());

        Console.Write("a = ");

        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b = ");

        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("x = ");

        double x = Convert.ToDouble(Console.ReadLine());

        double z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3) * n) + (n * m) + Math.Pow(m, 2) - m);

        double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

        double y = (2.4 * Math.Abs((Math.Pow(x, 2)) + (b)) / (a)) + ((a - b) * (Math.Pow(Math.Sin((a - b) + (Math.Pow(10, -2) * (x - b))), 2)));

        Console.Write("Розрахунок виразів:");

        Console.Write("\nz1 = " + z1);

        Console.Write("\nz2 = " + z2);

        Console.Write("\ny = " + y);
    }
}