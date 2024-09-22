double time = double.Parse(Console.ReadLine());
string day = Console.ReadLine();

if (day == "Monday")
{
    if (time >= 10 && time <= 18)
    {
        Console.WriteLine("open");
    }
    else if (time < 10 || time > 18)
    {
        Console.WriteLine("closed");
    }

}
else if (day == "Tuesday")
{
    if (time >= 10 && time <= 18)
    {
        Console.WriteLine("open");
    }
    else if (time < 10 || time > 18)
    {
        Console.WriteLine("closed");
    }

}
else if (day == "Wednesday")
{
    if (time >= 10 && time <= 18)
    {
        Console.WriteLine("openn");
    }
    else if (time < 10 || time > 18)
    {
        Console.WriteLine("closed");
    }

}
else if (day == "Thursday")
{
    if (time >= 10 && time <= 18)
    {
        Console.WriteLine("open");
    }
    else if (time < 10 || time > 18)
    {
        Console.WriteLine("closed");
    }

}
else if (day == "Friday")
{
    if (time >= 10 && time <= 18)
    {
        Console.WriteLine("Open");
    }
    else if (time < 10 || time > 18)
    {
        Console.WriteLine("closed");
    }

}
else if (day == "Saturday")
{
    if (time >= 10 && time <= 18)
    {
        Console.WriteLine("open");
    }
    else if (time < 10 || time > 18)
    {
        Console.WriteLine("closed");
    }

}
else
{
    Console.WriteLine("closed");
}