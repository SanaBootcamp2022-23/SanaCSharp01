class Program
{
    static void Main()
    {
        double z1, z2, m, n, y, a, b, x;
        Console.Write("Enter a number a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Enter a number b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Enter a number x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Enter a number m: ");
        m = double.Parse(Console.ReadLine());
        Console.Write("Enter a number n: ");
        n = double.Parse(Console.ReadLine());
        z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + (m * m) - m);
        Console.WriteLine($"z1 = {z1}");
        z2 = ((Math.Sqrt(m) - Math.Sqrt(n)) / m);
        Console.WriteLine($"z2 = {z2}");
        y = 2.4 * Math.Abs(((x * x) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
        Console.WriteLine($"y = {y}");
    }
}