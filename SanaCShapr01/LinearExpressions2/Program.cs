System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double m, n, x, a, b;

do
{
    Console.Write("Enter 'm': ");
    if (!double.TryParse(Console.ReadLine(), out m))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'm': ");
    }
    else
    {
        Console.WriteLine("The number 'm' is entered correctly!");
        break;
    }
} while (!double.TryParse(Console.ReadLine(), out m));

do
{
    Console.Write("Enter 'n': ");
    if (!double.TryParse(Console.ReadLine(), out n))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'n': ");
    }
    else
    {
        Console.WriteLine("The number 'n' is entered correctly!");
        break;
    }
} while (!double.TryParse(Console.ReadLine(), out n));

do
{
    Console.Write("Enter 'x': ");
    if (!double.TryParse(Console.ReadLine(), out x))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'x': ");
    }
    else
    {
        Console.WriteLine("The number 'x' is entered correctly!");
        break;
    }
} while (!double.TryParse(Console.ReadLine(), out x));

do
{
    Console.Write("Enter 'a': ");
    if (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'a': ");
    }
    else
    {
        Console.WriteLine("The number 'a' is entered correctly!");
        break;
    }
} while (!double.TryParse(Console.ReadLine(), out a));

do
{
    Console.Write("Enter 'b': ");
    if (!double.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'b': ");
    }
    else
    {
        Console.WriteLine("The number 'b' is entered correctly!");
        break;
    }
} while (!double.TryParse(Console.ReadLine(), out b));

Console.WriteLine($"\nInputed m: {m}");
Console.WriteLine($"Inputed n: {n}");
Console.WriteLine($"Inputed x: {x}");
Console.WriteLine($"Inputed a: {a}");
Console.WriteLine($"Inputed b: {b}");

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
double y = 2.4 * Math.Abs((x * x + b) / a) + (a + b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine($"\nThe result of expression z1: {Math.Round(z1, 4)}");
Console.WriteLine($"The result of expression z2: {Math.Round(z2, 4)}");
Console.WriteLine($"The result of expression y: {Math.Round(y, 4)}");
