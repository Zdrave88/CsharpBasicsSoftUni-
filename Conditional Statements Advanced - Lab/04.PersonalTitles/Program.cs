
double age = double.Parse(Console.ReadLine());    
string gender  = Console.ReadLine();

//if (gender == "m")
//{
//    if (age >= 16)
//    {
//        Console.WriteLine("Mr.");
//    }
//    else
//    {
//        Console.WriteLine("Master");
//    }
//}
//else if (gender == "f")
//{
//    if (age >= 16)
//    {
//        Console.WriteLine("Ms.");
//    }
//    else
//    {
//        Console.WriteLine("Miss");
//    }
//}
if (age >= 16) 
{
    if (gender == "m") 
    {
        Console.WriteLine("Mr.");
    }
    else if (gender == "f")
    {
        Console.WriteLine("Ms.");
    }
}
else
{
    if (gender == "m")
    {
        Console.WriteLine("Master");
    }
    else if (gender == "f")
    {
        Console.WriteLine("Miss");
    }

}
