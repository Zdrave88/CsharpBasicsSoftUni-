int distance = int.Parse(Console.ReadLine());
string time = Console.ReadLine();   
string daytime  = "day";
string nighttime = "night";

//смятам ако разстоянието е по-малко от 20км - ТАКСИ  
if (distance < 20)
{
    double startPrice = 0.79;

    if (daytime == daytime)
    {
        double taxiRideDay = 0.70;
        double dayRide = distance * taxiRideDay + startPrice;
        Console.WriteLine($"{dayRide:f2}");
    }
    else
    {
        double taxiRideNight = 0.90;
        double nightRide = distance * taxiRideNight + startPrice;
        Console.WriteLine($"{nightRide}");
    }

}
// ако разстоянието е >= 20км и < 100км - АВТОБУС
else if (distance >= 20 && distance < 100)
{
    double busPerKilometer = 0.09;
    double busRide = distance * busPerKilometer;
    Console.WriteLine($"{busRide:f2}";
}
// ако разстоянието е над 100 - ВЛАК
else
{
    double trainPerKilometer = 0.06;
    double trainRide = distance * trainPerKilometer;
    Console.WriteLine($"{trainRide:f2}");
}