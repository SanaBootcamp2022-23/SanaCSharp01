using System;

namespace LinearExpressions1
{
    public class Program
    {
        static void Main(string[] args) {
            try {
                Console.Write("Enter value of a: ");
                double a = Double.Parse(Console.ReadLine());
                Console.Write("Enter value of b: ");
                double b = Double.Parse(Console.ReadLine());
                Console.Write("Enter value of c: ");
                double c = Double.Parse(Console.ReadLine());
                Console.Write("Enter value of d: ");
                double d = Double.Parse(Console.ReadLine());

                double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
                double y = 10 * (a + b) * (c - d) / c + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
                double z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / 
                    (5 * a + 3 * b);
                double r = (a / 2 + 3 * b / 4 - 7.0 / 5.0) / (3 * c + 1) + 1 / (a - c);

                Func<double, bool> checkForDivisionByZero = res => Double.IsInfinity(res) || Double.IsNaN(res);
                string undefinedResult = "undefined (division by zero)";
                
                Console.WriteLine();
                Console.WriteLine($"Value of x: {(checkForDivisionByZero(x) ? undefinedResult : x)}");
                Console.WriteLine($"Value of y: {(checkForDivisionByZero(y) ? undefinedResult : y)}");
                Console.WriteLine($"Value of z: {(checkForDivisionByZero(z) ? undefinedResult : z)}");
                Console.WriteLine($"Value of r: {(checkForDivisionByZero(r) ? undefinedResult : r)}");
                    
            } catch (FormatException exception) {
                Console.WriteLine(exception.Message);
            } catch (ArgumentNullException exception) {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
