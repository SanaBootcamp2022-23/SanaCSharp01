// See https://aka.ms/new-console-template for more information

//введення, оголошення та перетворення змінних 
Console.WriteLine("Input m:");
double m = double.Parse(Console.ReadLine());
Console.WriteLine("Input n:");
double n = double.Parse(Console.ReadLine());

//обчислення виразів
double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

//виведення результату 1 та 2 виразу
Console.WriteLine($"\nz1 = {z1}, z2 = {z2}\n");

//введення, оголошення та перетворення змінних 
Console.WriteLine("Input a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Input b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Input x:");
double x = double.Parse(Console.ReadLine());

//обчислення виразу
double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

//виведення результату 3го виразу
Console.WriteLine($"\ny = {y}");

