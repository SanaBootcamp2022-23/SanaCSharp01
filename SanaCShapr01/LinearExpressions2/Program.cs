Console.WriteLine("-------------------------------------------------------" +
    "\nSimple program to calculate values. " +
    "Powered by WAYLIIKE!\n" +
    "-------------------------------------------------------");
Console.WriteLine("\nEnter 5 values below to calculate z1, z2, y.\n");
double z1, z2, y;
Console.Write("Enter m: ");
double m = double.Parse(Console.ReadLine());
Console.Write("Enter n: ");
double n = double.Parse(Console.ReadLine());
Console.Write("Enter a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Enter b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Enter x: ");
double x = double.Parse(Console.ReadLine());
z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) /
    (Math.Sqrt(Math.Pow(m, 3)*n) + n*m + m*m - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = (2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b) * Math.Sin(a - b)
    + Math.Pow(10, -2) * (x - b));
Console.WriteLine("\nRESULTS:\nValue z1 = " + z1);
Console.WriteLine("Value z2 = " + z2);
Console.WriteLine("Value y = " + y);