// See https://aka.ms/new-console-template for more information

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть значення змінної M -> ");
double varM = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення змінної N -> ");
double varN = Convert.ToDouble(Console.ReadLine());

double resultZ1 = ((varM - 1) * Math.Sqrt(varM) - (varN - 1) * Math.Sqrt(varN)) / (Math.Sqrt(Math.Pow(varM, 3) * varN) + varN * varM + Math.Pow(varM, 2) - varM);
Console.WriteLine(resultZ1);