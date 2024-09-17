double radius = double.Parse(Console.ReadLine());
double area = Math.Pow(radius, 2) * Math.PI;
double perimeter = (Math.PI * radius) * 2;
Console.WriteLine($"{area:f2}");
Console.WriteLine($"{perimeter:f2}");
