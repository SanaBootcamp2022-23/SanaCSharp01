﻿
Console.WriteLine("--- Програма обчислення лiнiйних виразiв ---");
Console.WriteLine("Для обчислення необхiдно ввести початковi значення");
double a, b, c, d, x, y, z, r;
Console.WriteLine("Введiть а: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введiть b: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введiть c: ");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Введiть d: ");
d = double.Parse(Console.ReadLine());
Console.WriteLine("- - - - - - - - - - - - -");
Console.WriteLine("Вхiднi данi:");
Console.WriteLine("а = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);
Console.WriteLine("- - - - - - - - - - - - -");

Console.WriteLine("Результати виконання формул: ");
x = ((a + 2*b - c + d)/(c*d)) + ((a + b)/(c - d)) - ((a*a)/(b*b));
Console.WriteLine("x = " + x);

y = ((5*(a + b)*(c - d))/((1/2)*c)) + ((d*d)*(((a*a) - (b*b))/(b - a)));
Console.WriteLine("y = " + y);
//y = (5 * (a + b) * (c - d)) / ((1 / 2) * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
z = (((Math.Pow((x*x - 2*x),3)) - 4*(Math.Pow(x,4) + 1))*(1 - b)) / (5*a + 3*b);
Console.WriteLine("z = " + z);
r = ((((1/2)*a)+((3/4)*b)-(7/5))/(3*c + 1)) + (1/(a - c));
Console.WriteLine("r = " + r);