using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8; //Для коректного відображення літери "і"

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, c, d;

do
{
    Console.Write("Введіть a: ");
    if (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Введіть коректне значення a: ");
    }
    else { break; }
} while (!double.TryParse(Console.ReadLine(), out a));

do
{
    Console.Write("Введіть b: ");
    if (!double.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Введіть коректне значення b: ");
    }
    else { break; }
} while (!double.TryParse(Console.ReadLine(), out b));

do
{
    Console.Write("Введіть c: ");
    if (!double.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Введіть коректне значення c: ");
    }
    else { break; }
} while (!double.TryParse(Console.ReadLine(), out c));

do
{
    Console.Write("Введіть d: ");
    if (!double.TryParse(Console.ReadLine(), out d))
    {
        Console.Write("Введіть коректне значення d: ");
    }
    else { break; }
} while (!double.TryParse(Console.ReadLine(), out d));
//Перевіряємо введені дані

double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (a * a / (b * b));
double y = (5 * (a + b) * (c - d) / (1.0 / 2 * c)) + d * d * ((a * a - b * b) / (b - a));
double z = ((Math.Pow((x * x - 2 * x), 3) - (4 * (Math.Pow(x, 4) + 1))) * (1 - b)) / (5 * a + 3 * b);
double r = ((1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1)) + (1 / (a - c));

Console.WriteLine("\nРезультат:");
Console.WriteLine($"Число x: {Math.Round(x, 3)}");
Console.WriteLine($"Число y: {Math.Round(y, 3)}");
Console.WriteLine($"Число z: {Math.Round(z, 3)}");
Console.WriteLine($"Число r: {Math.Round(r, 3)}");