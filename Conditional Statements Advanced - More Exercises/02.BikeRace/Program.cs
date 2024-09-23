int juniors = int.Parse(Console.ReadLine());
int seniors = int.Parse(Console.ReadLine());
string trail = Console.ReadLine();

double all = juniors + seniors;
double taxJ = 0.0;
double taxS = 0.0;
double total = 0.0;
switch (trail)
{
    case "trail": taxJ = juniors * 5.50; taxS = seniors * 7; total = taxJ + taxS; break;
    case "cross-country":
        if (trail == "cross-country" && all >= 50)
        {
            taxJ = juniors * (8 - (8 * 0.25));
            taxS = seniors * (9.50 - (9.50 * 0.25));
            total = taxJ + taxS;
        }
        else
        {
            taxJ = juniors * 8;
            taxS = seniors * 9.50;
            total = taxJ + taxS;
        }
        break;
    case "downhill": taxJ = juniors * 12.25; taxS = seniors * 13.75; total = taxJ + taxS; break;
    case "road": taxJ = juniors * 20; taxS = seniors * 21.50; total = taxJ + taxS; break;
}

double tax = (total * 0.05);
double donation = total - tax;
Console.WriteLine($"{donation:f2}");
