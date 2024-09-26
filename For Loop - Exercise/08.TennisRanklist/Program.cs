int numberOfTurnirs = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());

int totalPoints = startingPoints;
int wonTurnirs = 0;
for (int i = 1; i <= numberOfTurnirs; i++)
{
    string addedPoints = Console.ReadLine();
    if (addedPoints == "W")
    {
        wonTurnirs++;
        totalPoints += 2000;
    }
    if (addedPoints == "F")
    {
        totalPoints += 1200;
    }
    if (addedPoints == "SF")
    {
        totalPoints += 720;
    }
}
double averagePoints = (totalPoints - startingPoints) / numberOfTurnirs;
double percentageWonTurninrs = ((double)wonTurnirs / numberOfTurnirs) * 100;

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{percentageWonTurninrs:f2}%");