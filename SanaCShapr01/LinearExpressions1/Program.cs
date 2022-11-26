System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, c, d;

do
{
    Console.Write("Enter 'a': ");
    if (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'a': "); 
    } else
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

do
{
    Console.Write("Enter 'c': ");
    if (!double.TryParse(Console.ReadLine(), out c))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'c': ");
    }
    else
    {
        Console.WriteLine("The number 'c' is entered correctly!");
        break;
    }
} while (!double.TryParse(Console.ReadLine(), out c));

do
{
    Console.Write("Enter 'd': ");
    if (!double.TryParse(Console.ReadLine(), out d))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'd': ");
    }
    else
    {
        Console.WriteLine("The number 'd' is entered correctly!");
        break;
    }
} while (!double.TryParse(Console.ReadLine(), out d));

Console.WriteLine($"\nInputed a: {a}");
Console.WriteLine($"Inputed b: {b}");
Console.WriteLine($"Inputed c: {c}");
Console.WriteLine($"Inputed d: {d}");

double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (a * a / (b * b));
double y = (5 * (a + b) * (c - d) / (1 / 2 * c)) + d * d * ((a * a - b * b) / (b - a));
double z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
double r = ((1 / 2  * a + 3 / 4 * b - 7 / 5) / (3 * c + 1)) + (1 / (a - c));

Console.WriteLine($"\nThe result of expression x: {Math.Round(x, 4)}");
Console.WriteLine($"The result of expression y: {Math.Round(y, 4)}");
Console.WriteLine($"The result of expression z: {Math.Round(z, 4)}");
Console.WriteLine($"The result of expression r: {Math.Round(r, 4)}");