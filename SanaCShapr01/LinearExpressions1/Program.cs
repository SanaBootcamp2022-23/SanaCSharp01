double a, b, c, d, x;
double expressionsX, expressionsY, expressionsZ, expressionsR;

Console.WriteLine("Enter A:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter B:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter C:");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter D:");
d = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter x:");
x = Convert.ToDouble(Console.ReadLine());

expressionsX = ((a+(2*b)-c+d)/(c*d))+ (a + b / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
expressionsY = (5 * (a + b) * (c - d)) / ((1 / 2.0) * c) + (Math.Pow(d,2)*((Math.Pow(a,2)-Math.Pow(b,2))/(b-a)));
expressionsZ = ((Math.Pow((Math.Pow(x, 2) - (2 * x)), 3) - (4 * (Math.Pow(x, 4) + 1)))*(1-b))/((5*a)+(3*b));
expressionsR = ((((1 / 2.0) * a) + ((3 / 4.0) * b) - (7 / 5.0))/((3*c)+1))+(1/(a-c));
Console.WriteLine($"Expressions X: {expressionsX}\nExpressions Y: {expressionsY}\nExpressions Z: {expressionsZ}\nExpressions R: {expressionsR}\n");