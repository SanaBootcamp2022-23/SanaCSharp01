using System;

class Program {
  public static void Main (string[] args) {
   double a, b, c, d, x, y, z, r;

Console.WriteLine("Enter the value of a");
Console.Write("-> ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of b");
Console.Write("-> ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of c");
Console.Write("-> ");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of d");
Console.Write("-> ");
d = double.Parse(Console.ReadLine());

x = (a+2*b-c+d)/(c*d)+(a+b)/(c-d)-Math.Pow(a, 2)/Math.Pow(b, 2);
y = (5 * (a + b)*(c - d)) / (0.5 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b))/(5*a+3*b);
r = ((a*1)/2 + (b* 3)/4  - 7/5)/(3 * c + 1) + (1 / (a - c));

Console.WriteLine("the value of x -> " + x );
Console.WriteLine("the value of y -> " + y );
Console.WriteLine("the value of z -> " + z );
Console.WriteLine("the value of r -> " + r );


  }
}