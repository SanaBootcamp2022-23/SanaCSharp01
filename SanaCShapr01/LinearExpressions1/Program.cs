Console.WriteLine("-------------------------------------------------------" +
    "\nSimple program to calculate values. " +
    "Powered by WAYLIIKE!\n" +
    "-------------------------------------------------------");
Console.WriteLine("\nEnter 4 values below to calculate x, y, z, r.\n");
Console.Write("Enter a: ");
double x, y, z, r;
double a = double.Parse(Console.ReadLine());
Console.Write("Enter b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Enter c: ");
double c = double.Parse(Console.ReadLine());
Console.Write("Enter d: ");
double d = double.Parse(Console.ReadLine());
x = (((a + (2 * b) - c + d) / (c * d)) + ((a + b) / (c - d)) - 
    ((Math.Sqrt(a)) / (Math.Sqrt(b))));
y = (((5 * (a + b) * (c - d)) / (0.5 * c)) +
    (Math.Sqrt(d) * ((Math.Sqrt(a) - Math.Sqrt(b)) / (b - a))));
z = ((((Math.Pow((Math.Sqrt(x) - 2 * x), 3)) - 
    (4*(Math.Pow(x, 4) + 1)))*(1 - b))/(5*a + 3*b));
r = (((0.5*a + 0.75*b - 1.4)/(3*c + 1)) + (1/(a - c)));
Console.WriteLine("\nRESULTS:\nValue x = " + x);
Console.WriteLine("Value y = " + y);
Console.WriteLine("Value z = " + z);
Console.WriteLine("Value r = " + r);



