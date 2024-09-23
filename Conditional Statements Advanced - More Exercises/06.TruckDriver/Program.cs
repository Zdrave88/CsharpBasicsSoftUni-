string season = Console.ReadLine();
double kilometers = double.Parse(Console.ReadLine());

double pricePerKm = 0.0;
if (kilometers <= 5000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn": pricePerKm = 0.75; break;
        case "Summer": pricePerKm = 0.90; break;
        case "Winter": pricePerKm = 1.05; break;
    }
}
else if (kilometers > 5000 && kilometers <= 10000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn": pricePerKm = 0.95; break;
        case "Summer": pricePerKm = 1.10; break;
        case "Winter": pricePerKm = 1.25; break;
    }
}
else // km > 10000 && km <= 20000
{
    switch (season)
    {
        case "Spring":
        case "Autumn":
        case "Summer":
        case "Winter": pricePerKm = 1.45; break;
    }
}
double salary = kilometers * pricePerKm;
double salaryForSeason = salary * 4;
double totalSalary = salaryForSeason * 0.90;
Console.WriteLine($"{totalSalary:f2}");
