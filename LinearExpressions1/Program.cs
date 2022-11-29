// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

double a, b, c, d, x, y, z, r;

Console.WriteLine("Hello! Today we`ll solve 4 question question with fractional variables " +
                    "\"a\", \"b\", \"c\" and \"d\".");
Console.WriteLine("Please, use separator \".\" when you'll enter numbers.");
Console.WriteLine("Lets start!");
Console.WriteLine("");

Console.WriteLine("Now, you should input the first fractional variable \"a\":");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Graet! Input the second fractional variable \"b\":");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Very well! Input the third fractional variable \"c\":");
c = double.Parse(Console.ReadLine());
Console.WriteLine("And finally, input the fourth fractional variable \"d\": ");
d = double.Parse(Console.ReadLine());
Console.WriteLine("");

x = ((a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (Math.Pow(a, 2) / Math.Pow(b, 2)));
Console.WriteLine($"The result of (a+2b-c+d)/(cd)+(a+b)/(c-d)-(a^2)/(b^2) is: {x}");

y = ((5 * (a + b) * (c - d)) / 0.5 * c + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a))));
Console.WriteLine($"The result of (5(a+b)(c-d))/(0.5*c)+(d^2*((a^2-b^2)/(b-a)) is: {y}");

z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b); 
Console.WriteLine($"The result of ((x^2-2x)^3-4(x^4+1))(1-b)/(5a+3b) is: {z}");

r = (0.5 * a + 3 / 4 * b - 7 / 5) / (3 * c + 1) + (1 / (a - c));
Console.WriteLine($"The result of (1/2a+3/4b-7/5)/(3c+1)+1/(a-c) is: {r}");
