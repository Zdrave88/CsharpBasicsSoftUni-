// ВХОДБИ ДАННИ
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine(); 
int fisherman  = int.Parse(Console.ReadLine());

// ПРОВЕРЯВАМ КОЙ СЕЗОН Е ЗА СЪОТВЕТНА ЦЕНА
double priceOfTheBoat = 0;
switch (season)
{
    case "Spring": priceOfTheBoat = 3000;
        break;
    case "Summer": priceOfTheBoat = 4200;
        break;
    case "Autumn": priceOfTheBoat = 4200;
        break;
    case "Winter": priceOfTheBoat = 2600;
        break;
}
// ПРОВЕРЯВАМ КОЛКО СА РИБАРИТЕ
if (fisherman <= 6)
{
    priceOfTheBoat *= 0.9;
    //priceOfTheBoat = priceOfTheBoat - (priceOfTheBoat * 0.10);
}
else if (fisherman >= 7 && fisherman <= 11)
{
    priceOfTheBoat *= 0.85;
}
else if (fisherman >=12)
{
    priceOfTheBoat *= 0.75;
}
// ПРОВЕРЯВАМ ДАЛИ СА ЧЕТЕН БРОЙ И ДАЛИ НЕ Е ЕСЕН
if (fisherman % 2 == 0 && season != "Autumn")
{
    priceOfTheBoat *= 0.95;
}
// ПРОВЕРЯВАМ ДАЛИ БЮДЖЕТА Е ДОСТАТЪЧЕН
if (budget >= priceOfTheBoat)
{
    double moneyLeft = budget - priceOfTheBoat;
    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
}
else
{ 
    double moneyNeeded = Math.Abs(priceOfTheBoat - budget);
    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");

}