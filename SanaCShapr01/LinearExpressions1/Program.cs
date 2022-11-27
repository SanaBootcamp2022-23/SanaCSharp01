double a, b, c, d;
Console.WriteLine("Fractional number a:");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Fractional number b:");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Fractional number c:");
c = double.Parse(Console.ReadLine());

Console.WriteLine("Fractional number d:");
d = double.Parse(Console.ReadLine());

double resultX = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
Console.WriteLine($"X: \n{resultX}");

double resultY = ((5 * (a + b) * (c - d)) / (0.5 * c)) + (d * d) * (((a * a) - (b * b)) / (b - a));
Console.WriteLine($"Y: \n{resultY}");

double resultZ = (Math.Pow(resultX * resultX - 2 * resultX, 3) - 4 * (Math.Pow(resultX, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine($"Z: \n{resultZ}");

double resultR = ((0.5 * a) + (3 / 4 * b) - (7 / 5)) / (3 * c + 1) + (1 / (a - c));
Console.WriteLine($"R: \n{resultR}");




