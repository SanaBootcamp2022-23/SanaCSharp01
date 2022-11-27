namespace LinearExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m = 0;
            double n = 0;

            double a = 0;
            double b = 0;
            double d = 0;
            double x = 0;

            double z1 = 0;
            double z2 = 0;
            double y = 0;
            
            bool isCorrect = false;
            do
            {
                try
                {
                    Console.WriteLine("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter d:");
                    d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter x:");
                    x = Convert.ToDouble(Console.ReadLine());

                    isCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Error, enter values again");
                    Console.ReadKey();
                }
            }
            while (!isCorrect);

            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3)) * n + n * m + Math.Pow(m, 2) - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

            Console.WriteLine($"z1 = {z1}\nz2 = {z2}\ny = {y}");
        }
    }
}