string flowerType = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double flowerPrice = 0;
switch (flowerType)
{
    case "Roses": flowerPrice = 5; break;
    case "Dahlias": flowerPrice = 3.8; break;
    case "Tulips": flowerPrice = 2.8; break;
    case "Narcissus": flowerPrice = 3; break;
    case "Gladiolus": flowerPrice = 2.5; break;
}

double totalCost = flowersCount * flowerPrice;

if (flowerType == "Roses" && flowersCount > 80)
{
    totalCost *= 0.9;
}
else if (flowerType == "Dahlias" && flowersCount > 90)
{
    totalCost *= 0.85;
}
else if (flowerType == "Tulips" && flowersCount > 80)
{
    totalCost *= 0.85;
}
else if (flowerType == "Narcissus" && flowersCount < 120)
{
    totalCost *= 1.15;
}
else if (flowerType == "Gladiolus" && flowersCount < 80)
{
    totalCost *= 1.20;
}
if (totalCost <= budget)
{
    double moneyLeft = budget - totalCost;
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {moneyLeft:f2} leva left.");
}
else
{
    double moneyNeeded = totalCost - budget;
    Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
}

