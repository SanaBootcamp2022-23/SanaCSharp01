// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Введiть значення для a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введiть значення для b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введiть значення для c: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введiть значення для d: ");
double d = Convert.ToDouble(Console.ReadLine());

double x;
x = ((a+2*b-c+d)/(c*d))-((a+b)/(c-d))-((Math.Pow(a,2))/ (Math.Pow(b, 2)));
Console.WriteLine($"x = {x}");
double y = ((5 * (a + b) * (c - d)) / (1.0 / 2.0) * c) + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)));
Console.WriteLine($"y = {y}");
double z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine($"z = {z}");
double r = ((((1 / 2) * a) + ((1 / 3) * b)-(7/5))/((3*c)+1))+(1/(a-c));