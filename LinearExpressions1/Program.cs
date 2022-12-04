using System.Runtime.CompilerServices;

double a, b, c, d;

Console.WriteLine("Hello, please, enter linear data for computing expressions");

a = enterData("a=");
b = enterData("b=");

c = enterData("c=");
d = enterData("d=");

outResult("x = ", computeX(a, b, c, d));
outResult("y = ", computeY(a, b, c, d));
outResult("z = ", computeZ(a, b, computeX(a,b,c,d)));
outResult("r = ", computeR(a, b, c));


double computeX(double a, double b, double c, double d)
{
    double firstPart = (a + 2 * b - c + d) / c * d;
    double secondPart = (a + b) / (c - d);
    double thirdPart = Math.Pow(a,2) / Math.Pow(b,2);
    return firstPart + secondPart - thirdPart;
}

double computeY(double a, double b, double c, double d)
{
    double firstPart = (5 * (a + b) *  (c - d))/ (c / 2);
    double secondPart = (Math.Pow(d,2) * (Math.Pow(a,2) - Math.Pow(b,2)))/(b - a);
    return firstPart + secondPart;
}

double computeZ(double a, double b, double x)
{
    return (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) /
        (5 * a + 3 * b ); 
}

double computeR(double a, double b, double c)
{
    double firstPart = (a / 2 + (3 * b / 4) - (7 / 5))/(3 * c + 1);
    double secondPart = 1 / (a - c);
    return firstPart + secondPart;
}

void outResult(string s, double x)
{
    Console.WriteLine(s + x);
}


double enterData(String s)
{
    
    Console.WriteLine(s);
    string consoleString = Console.ReadLine();
    return double.Parse(consoleString);
}
