int cropArea = int.Parse(Console.ReadLine());
double grapePerSquareMeter = double.Parse(Console.ReadLine());
int desiredWine = int.Parse(Console.ReadLine());    
int workers = int.Parse(Console.ReadLine());    
//смятам обема на лозето
double totalGrape = cropArea * grapePerSquareMeter;
// смятам количеството вино в лоитри
double wineLiters = (totalGrape * 0.4) / 2.5;
// проверка за достатъчно вино
if (wineLiters < desiredWine)
{ 
    double neededWine = Math.Floor(desiredWine - wineLiters);
    Console.WriteLine($"It will be a tough winter! More {neededWine} liters wine needed.");
}
else
{
    double wineLeft = Math.Ceiling(wineLiters - desiredWine);
    double winePerWorker = Math.Ceiling(wineLeft / workers);
    Console.WriteLine($"Good harvest this year! Total wine: {wineLiters} liters.");
    Console.WriteLine($"{wineLeft} liters left -> {winePerWorker} liters per person.");
}