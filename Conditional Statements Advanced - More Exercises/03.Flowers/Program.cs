int hrizantemiCount = int.Parse(Console.ReadLine());
int roziCount = int.Parse(Console.ReadLine());
int laletaCount = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
char holyday = char.Parse(Console.ReadLine());

double totalHrizantemi = 0.0;
double totalRozi = 0.0;
double totalLaleta = 0.0;
if (season == "Spring" || season == "Summer")
{
    double hrizantema = 2.0;
    double roza = 4.10;
    double lale = 2.50;
    totalHrizantemi = hrizantemiCount * hrizantema;
    totalRozi = roziCount * roza;
    totalLaleta = laletaCount * lale;
}
else
{
    double hrizantema = 3.75;
    double roza = 4.50;
    double lale = 4.15;
    totalHrizantemi = hrizantemiCount * hrizantema;
    totalRozi = roziCount * roza;
    totalLaleta = laletaCount * lale;
}
double total = totalRozi + totalHrizantemi + totalLaleta;

if (holyday == 'Y')
{
    total += total * 0.15;
}

if (laletaCount > 7 && season == "Spring")
{
    total -= total * 0.05;
}
else if (roziCount >= 10 && season == "Winter")
{
    total -= total * 0.10;
}

double allFlowers = roziCount + laletaCount + hrizantemiCount;
if (allFlowers > 20)
{
    total -= total * 0.20;
}
double final = total + 2;
Console.WriteLine($"{final:f2}");