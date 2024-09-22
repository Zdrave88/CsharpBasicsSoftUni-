// ВХОДНИ ДАННИ
double budget = double.Parse(Console.ReadLine());
string season  = Console.ReadLine();

// ОПРЕДЕЛЯМ КОЛКО Е БЮДЖЕТА И КЪДЕ
string destination = "";
string vacationType = "";
double moneyToSpend = 0; 
// колко е бюджета
if (budget <= 100)
{   // къде ще ходи с този бюджет
    destination = "Bulgaria";
    if (season == "summer")
    {
        vacationType = "Camp";
        moneyToSpend = budget * 0.3;
    }
    else if (season == "winter")
    {
        vacationType = "Hotel";
        moneyToSpend = budget * 0.7;
    }

}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        vacationType = "Camp";
        moneyToSpend = budget * 0.4;
    }
    else if (season == "winter")
    {
        vacationType = "Hotel";
        moneyToSpend = budget * 0.8;
    }

}
else
{
    destination = "Europe";
    vacationType = "Hotel";
    moneyToSpend = budget * 0.9;
}
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{vacationType} - {moneyToSpend:f2}");