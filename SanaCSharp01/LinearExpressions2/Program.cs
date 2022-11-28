System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;


Console.WriteLine("Please, enter 5 numbers for calculations.");

Console.Write("Enter first number (a): ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number (b): ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter third number (x): ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter last number (m): ");
double m = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter last number (n): ");
double n = Convert.ToDouble(Console.ReadLine());


double z1 = ((m -1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + (n * m) + Math.Pow(m, 2) - m);
Console.WriteLine($"\nz1 = {Math.Round(z1, 4)}");

double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"\nz2 = {Math.Round(z2, 4)}");

double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"\ny = {Math.Round(y, 4)}");

Console.ReadKey();