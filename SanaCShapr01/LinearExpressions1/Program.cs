double a, b, c, d, z,x,y,r;
Console.WriteLine("Enter number a: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number b: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number c: ");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number d: ");
d = double.Parse(Console.ReadLine());
double x1, x2, x3, y1, y2, z1, z2;
x1 = c * d;
x2 = c - d;
x3 = Math.Pow(b, 2);
if(x1!=0 && x2!=0 && x3 != 0) { 
    x = (a + 2 * b - c + d) / x1 + (a + b) / x2 - Math.Pow(a, 2)/x3;
    Console.WriteLine("x={0:F2}",x);
   
}
else { Console.WriteLine("Value is out of Domain of a function!!!"); };

