using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8; //Для коректного відображення літери "і"

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double m, n, a, b, x;

do
{
    Console.Write("Введіть m: ");
    if (!double.TryParse(Console.ReadLine(), out m))
    {
        Console.Write("Введіть коректне значення m: ");
    }
    else { break; }
} while (!double.TryParse(Console.ReadLine(), out m));

do
{
    Console.Write("Введіть n: ");
    if (!double.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Введіть коректне значення n: ");
    }
    else { break; }
} while (!double.TryParse(Console.ReadLine(), out n));

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
    Console.Write("Введіть x: ");
    if (!double.TryParse(Console.ReadLine(), out x))
    {
        Console.Write("Введіть коректне значення x: ");
    }
    else { break; }
} while (!double.TryParse(Console.ReadLine(), out x));

//Перевіряємо введені дані

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
double y = 2.4 * Math.Abs((x * x + b) / a) + (a + b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("\nРезультат:");
Console.WriteLine($"Число z1: {Math.Round(z1, 3)}");
Console.WriteLine($"Число z2: {Math.Round(z2, 3)}");
Console.WriteLine($"Число y: {Math.Round(y, 3)}");