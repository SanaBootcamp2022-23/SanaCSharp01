

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть число A: ");
        double numberA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть число B: ");
        double numberB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть число C: ");
        double numberC = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть число D: ");
        double numberD = Convert.ToDouble(Console.ReadLine());


        double resultX = ((numberA + (2 * numberB) - numberC + numberD) / numberC * numberD) + ((numberA + numberB) / (numberC - numberD)) - ((numberA * numberA) / (numberB * numberB));
        Console.WriteLine("X = " + resultX);

        double resultY = ((5 * (numberA + numberC) * (numberC - numberD)) / (1 / 2 * numberC)) + ((numberD * numberD) * ((numberA * numberA) - (numberB * numberB)) / numberB - numberA);
        Console.WriteLine("Y = " + resultY);

        Console.Write("Введіть число X: ");
        double numberX = Convert.ToDouble(Console.ReadLine());
        double resultZ = (Math.Pow(3, ((numberX * numberX) - (2 * numberX))) - (4 * Math.Pow(4, (numberX + 1)) * (1 - numberB))) / ((5 * numberA) + (3 * numberB));
        Console.WriteLine("Z = " + resultZ);

        double resultR = (((1 / 2) * numberA + (3 / 4) * numberB - (7 / 5)) / ((3 * numberC) + 1) + (1/(numberA-numberC)));
        Console.WriteLine("R = " + resultR);
    }
}