double a, b, c, d, z,x,y,r;
Console.WriteLine("Enter number a: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number b: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number c: ");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number d: ");
d = double.Parse(Console.ReadLine());
double x1, x2, x3, y1, y2, z1, r1, r2;
x1 = c * d;
x2 = c - d;
x3 = Math.Pow(b, 2);
if(x1!=0 && x2!=0 && x3 != 0) { 
    x = (a + 2 * b - c + d) / x1 + (a + b) / x2 - Math.Pow(a, 2)/x3;
    Console.WriteLine("x={0:F2}",x);
}
else { Console.WriteLine("Value is out of Domain of a function!!!"); };
y1 = c * (1 / 2);
y2 = b - a;
if (y1!=0 && y2 != 0)
{
    y = (5 * (a + b) * (c - d)) / y1 + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / y2);
    Console.WriteLine("y={0:F2}", y);
}
else { Console.WriteLine("Value is out of Domain of a function!!!"); };
z1 = 5 * a + 3 * b;
if (z1 != 0)
{
    x = (a + 2 * b - c + d) / x1 + (a + b) / x2 - Math.Pow(a, 2) / x3;
    z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / z1;
    Console.WriteLine("z={0:F2}", z);
}
else { Console.WriteLine("Value is out of Domain of a function!!!"); };
r1 = 3 * c + 1;
r2 = a - c;
if(r1!=0 && r2 != 0)
{
    r = (a * (1 / 2) + b * (3 / 4) - 7 / 5) / r1 + 1 / r2;
    Console.WriteLine("r={0:F2}", r);
}
