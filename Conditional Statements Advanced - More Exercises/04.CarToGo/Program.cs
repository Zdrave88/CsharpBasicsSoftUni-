double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string carType = string.Empty;
string carClass = string.Empty;
double carPrice = 0.0;
if (budget <= 100)
{
    carClass = "Economy class";
    switch (season)
    {
        case "Summer": carType = "Cabrio"; carPrice = budget * 0.35; break;
        case "Winter": carType = "Jeep"; carPrice = budget * 0.65; break;
    }
}
else if (budget > 100 && budget <= 500)
{
    carClass = "Compact class";
    switch (season)
    {
        case "Summer": carType = "Cabrio"; carPrice = budget * 0.45; break;
        case "Winter": carType = "Jeep"; carPrice = budget * 0.80; break;
    }
}
else // budget > 500
{
    carClass = "Luxury class";
    switch (season)
    {
        case "Summer":
        case "Winter": carType = "Jeep"; carPrice = budget * 0.90; break;
    }
}
Console.WriteLine($"{carClass}\n{carType} - {carPrice:f2}");