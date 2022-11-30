using System;

namespace LinearExpressions2
{
    public class Program
    {
        static void Main(string[] args) {
            try {
                Console.Write("Enter value of m: ");
                double m = Double.Parse(Console.ReadLine());
                Console.Write("Enter value of n: ");
                double n = Double.Parse(Console.ReadLine());
                Console.Write("Enter value of a: ");
                double a = Double.Parse(Console.ReadLine());
                Console.Write("Enter value of b: ");
                double b = Double.Parse(Console.ReadLine());
                Console.Write("Enter value of x: ");
                double x = Double.Parse(Console.ReadLine());

                double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / 
                    (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
                double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
                double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + 
                    1e-2 * (x - b);


                Func<double, bool> checkForDivisionByZero = res => Double.IsInfinity(res) || Double.IsNaN(res);
                string undefinedResult = "undefined (division by zero or negative square root)";
                
                Console.WriteLine();
                Console.WriteLine($"Value of z1: {(checkForDivisionByZero(z1) ? undefinedResult : z1)}");
                Console.WriteLine($"Value of z2: {(checkForDivisionByZero(z2) ? undefinedResult : z2)}");
                Console.WriteLine($"Value of y: {(checkForDivisionByZero(y) ? undefinedResult : y)}");
                    
            } catch (FormatException exception) {
                Console.WriteLine(exception.Message);
            } catch (ArgumentNullException exception) {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
