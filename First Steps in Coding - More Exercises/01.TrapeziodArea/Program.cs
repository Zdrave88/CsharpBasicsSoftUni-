double sideA = double.Parse(Console.ReadLine());
double sideB = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double area = (sideA + sideB) * height / 2;
Console.WriteLine($"{area:f2}");