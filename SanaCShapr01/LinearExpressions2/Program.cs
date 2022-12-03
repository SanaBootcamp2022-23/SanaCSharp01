double m, n, z1, z2, a, b, x, y;
Console.WriteLine("Enter m");
Console.Write(">");

m = double.Parse(Console.ReadLine());
Console.WriteLine("Enter n");
Console.Write(">");

n = double.Parse(Console.ReadLine());

Console.WriteLine("Calculating");
z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n))/(Math.Sqrt(Math.Pow(m,3)*n)+n*m+Math.Pow(m,2)-m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n) / m);

Console.WriteLine("z1:" + z2);
Console.WriteLine("z2:" + z2);


Console.WriteLine("Enter x");
Console.Write(">");

x = double.Parse(Console.ReadLine());
Console.WriteLine("Enter a");
Console.Write(">");

a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b");
Console.Write(">");

b = double.Parse(Console.ReadLine());
Console.WriteLine("Calculating");

y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("y:" + y);