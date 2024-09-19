// INPUT
int vineyardSquareMeters = int.Parse(Console.ReadLine());
double grapePerSquareMeter = double.Parse(Console.ReadLine());  
int desiredWinAmount  = int.Parse(Console.ReadLine());  
int workers = int.Parse(Console.ReadLine());

// CALCULATIONS
double totalGrape = vineyardSquareMeters * grapePerSquareMeter;                 // смятам обема на лозето
double wineLitter = (0.4 * totalGrape) / 2.5;                                   // смятам количеството вино в литри

// OUTPUT
if (wineLitter < desiredWinAmount)                                              // проверка за достатъчно вино
{
    double wineNeeded = Math.Floor(desiredWinAmount - wineLitter);
    Console.WriteLine($"It will be a tough winter! More {wineNeeded} liters wine needed.");

}
else
{
    double wineSurplus = Math.Ceiling(wineLitter - desiredWinAmount);
    double winePerWorker = Math.Ceiling(wineSurplus / workers);
    Console.WriteLine($"Good harvest this year! Total wine: {wineSurplus} liters.");
    Console.WriteLine($"{wineSurplus} liters left -> {winePerWorker} liters per person.");
}














//Console.WriteLine(wineLitter);