string name = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int juries = int.Parse(Console.ReadLine());


double pointsCollected = academyPoints;
for (int i = 0; i < juries; i++)
{
    string judgeName = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine());
    pointsCollected += ((judgeName.Length * judgePoints) / 2);
    if (pointsCollected > 1250.5)
    {
        Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {pointsCollected:f1}!");
        return;
    }
}
if (pointsCollected < 1250.5)
{
    Console.WriteLine($"Sorry, {name} you need {1250.5 - (pointsCollected):f1} more!");
}
