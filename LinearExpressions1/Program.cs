double a, b, c, d, x, y, z, r;
Console.Write("a= "); a = double.Parse(Console.ReadLine());
Console.Write("b= "); b = double.Parse(Console.ReadLine());
Console.Write("c= "); c = double.Parse(Console.ReadLine());
Console.Write("d= "); d = double.Parse(Console.ReadLine());

x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
Console.WriteLine($"x={x}");

y = ((5 * (a + b) * (c - d)) / ((1.0 / 2.0) * c)) + ((d * d) * ((a * a - b * b) / (b - a)));

Console.WriteLine($"y={y}");


z = (Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);


Console.WriteLine($"z={z}");

r = (((1.0 / 2.0) * a + (3.0 / 4.0) * b - (7.0 / 5.0)) / (3 * c + 1)) + (1 / (a - c));

Console.WriteLine($"r={r}");

