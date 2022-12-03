// See https://aka.ms/new-console-template for more information

double a, b, c, d, x, y, z, r; 

Console.Write("Input 'a' value: "); a = Convert.ToDouble(Console.ReadLine());
Console.Write("Input 'b' value: "); b = Convert.ToDouble(Console.ReadLine());
Console.Write("Input 'c' value: "); c = Convert.ToDouble(Console.ReadLine());
Console.Write("Input 'd' value: "); d = Convert.ToDouble(Console.ReadLine());

x = ((a + 2 * b - c + d) / (c * d) + ((a + b) / (c - d)) - ((a * a) / (b * b)));
y = ((5 * (a + b) * (c - d)) / (c / 2)) + d * d * ((a * a - b * b) / (b - a));
z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
r = ((a / 2 + (3 * b) / 4 - 7 / 5) / (3 * c + 1)) + 1 / (a - c);
    
Console.WriteLine("X equals " + x);
Console.WriteLine("Y equals " + y);
Console.WriteLine("Z equals " + z);
Console.WriteLine("R equals " + r);
