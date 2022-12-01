// See https://aka.ms/new-console-template for more information

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                    System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double m, // число для змінної m
    n, // число для змінної n
    a, // число для змінної a
    b, // число для змінної b
    x; // число для змінної x

Console.WriteLine("to calculate the formulla? entr the namber m");
m = double.Parse(Console.ReadLine());

Console.WriteLine("to calculate the formulla? entr the namber n");
n = double.Parse(Console.ReadLine());

Console.WriteLine("to calculate the formulla? entr the namber a");
a = double.Parse(Console.ReadLine());

Console.WriteLine("to calculate the formulla? entr the namber b");
b = double.Parse(Console.ReadLine());

Console.WriteLine("to calculate the formulla? entr the namber x");
x = double.Parse(Console.ReadLine());


double z2 = (Math.Sqrt(m) - Math.Sqrt(n))/ m;
Console.WriteLine($"z2 = (Math.Sqrt(m) - Math.Sqrt(n))/ m = {z2}");

Console.ReadKey();
