
string figure = Console.ReadLine(); 
double side = double.Parse(Console.ReadLine());
double area = 0;

if (figure == "square")
{
    area = side * side;
    //Console.WriteLine($"{area:f3}");
}
else if (figure == "rectangle")
{
    double side2 = double.Parse(Console.ReadLine());
    area = side * side2;
    //Console.WriteLine($"{area:f3}");
}
else if (figure == "circle")
{
    area = Math.PI * side * side;
    //Console.WriteLine($"{area:f3}");
}
else 
{
    double height = double.Parse(Console.ReadLine());
    area = side * height / 2;
    //Console.WriteLine($"{area:f3}");
}
Console.WriteLine($"{area:f3}");