Console.Write("Введiть дробове число а: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введiть дробове число b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введiть дробове число c: ");
double c = double.Parse(Console.ReadLine());

Console.Write("Введiть дробове число d: ");
double d = double.Parse(Console.ReadLine());

double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a*a) / (b*b));
Console.WriteLine($"Значення x: {x}");

double y = ((5 * (a + b) * (c - d)) / (0.5 * c)) + d*d * (((a*a) - (b*b)) / (b-a));
Console.WriteLine($"Значення y: {y}");

double z = ( (Math.Pow((x * x - 2.0 * x), 3) - (4 * (Math.Pow(x, 4) + 1.0)) ) * (1.0 - b)) / (5.0 * a + 3.0 * b);
Console.WriteLine($"Значення z: {z}");

double r = ((0.5 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1)) + (1 / (a - c));
Console.WriteLine($"Значення r: {r}");
