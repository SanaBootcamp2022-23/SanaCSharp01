// See https://aka.ms/new-console-template for more information

double NumberA;
double NumberB;
double NumberC; 
double NumberD;

Console.WriteLine("Enter the number A:");
NumberA = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the number B:");
NumberB = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the number C:");
NumberC = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the number D:");
NumberD = double.Parse(Console.ReadLine());

double ResultX =
    ((NumberA + 2 * NumberB - NumberC + NumberD) / (NumberC * NumberD)) + ((NumberA + NumberB) / (NumberC - NumberD)) - (Math.Pow(NumberA, 2)) / (Math.Pow(NumberB, 2));
Console.WriteLine($"Result X: \n {ResultX}");

double ResultY =
    ((5 * (NumberA + NumberB) * (NumberC - NumberD)) / (0.5 * NumberC)) + (NumberD * NumberD * (((NumberA * NumberA) - (NumberB * NumberB)) / (NumberB - NumberA)));
Console.WriteLine($"Result Y: \n {ResultY}");

double ResultZ =
    (((Math.Pow((Math.Pow(ResultX, 2) - 2 * ResultX), 3)) - 4 * (Math.Pow(ResultX, 4) + 1)) * (1 - NumberB)) / (5 * NumberA + 3 * NumberB);
Console.WriteLine($"Result Z: \n {ResultZ}");

double ResultR =
    (((0.5 * NumberA + 0.75 * NumberB - 1.4) / (3 * NumberC + 1)) + (1 / (NumberA - NumberC)));
Console.WriteLine($"Result R: \n {ResultR}");
