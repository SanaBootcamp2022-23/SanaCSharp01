// Practical work 03 at Sana Commerce courses. Part 1.
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("\n\t\t\tHello my dear friend!\n\n" +
                  "\tThis program inserts the variables you enter into the\n" +
                  "\tsecret expressions and calculates the X, Y, Z, and R values.\n\n" +
                  "\tIf you want to see how it works, input the \"Double\" variables\n" +
                  "\tA, B, C and D in sequence on the keyboard and get the result.\n" +
                  "\tIf not, just close the window.\n\n" +
                  "\tFinish entering each variable by pressing the \"Enter\" key.\n");

double variableA, // Variable A entered by the user
       variableB, // Variable B entered by the user
       variableC, // Variable C entered by the user
       variableD; // Variable D entered by the user

Console.Write("\t\t\tInput variable A: ");
        variableA = double.Parse(Console.ReadLine());
Console.Write("\t\t\tInput variable B: ");
        variableB = double.Parse(Console.ReadLine());
Console.Write("\t\t\tInput variable C: ");
        variableC = double.Parse(Console.ReadLine());
Console.Write("\t\t\tInput variable D: ");
        variableD = double.Parse(Console.ReadLine());

double valueX, // The value obtained from the results of the calculation of the first expression
       valueY, // The value obtained from the results of the calculation of the second expression
       valueZ, // The value obtained from the results of the calculation of the third expression
       valueR; // The value obtained from the results of the calculation of the fourth expression

       valueX = (variableA + 2 * variableB - variableC + variableD) / (variableC * variableD)
                + (variableA + variableB) / (variableC - variableD) - Math.Pow(variableA, 2) / Math.Pow(variableB, 2);

       valueY = 5 * (variableA + variableB) * (variableC - variableD) / (1 / 2.0 * variableC)
                + Math.Pow(variableD, 2) * (Math.Pow(variableA, 2) - Math.Pow(variableB, 2)) / (variableB - variableA);

       valueZ = (Math.Pow((Math.Pow(valueX, 2) - 2 * valueX), 3) - 4 * (Math.Pow(valueX, 4) + 1)) * (1 - variableB) /
                (5 * variableA + 3 * variableB);

       valueR = (1 / 2.0 * variableA + 3 / 4.0 * variableB - 7 / 5.0) / (3 * variableC + 1) + 1 / (variableA - variableC);

Console.WriteLine("\n\t\tAccording to the results of the calculations:\n" +
                 $"\t\t\tX = {valueX};\n\t\t\tY = {valueY};\n\t\t\tZ = {valueZ};\n\t\t\tR = {valueR}");

Console.WriteLine("\a");