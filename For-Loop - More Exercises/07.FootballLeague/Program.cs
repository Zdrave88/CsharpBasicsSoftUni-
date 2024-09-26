int stadiumCapacity = int.Parse(Console.ReadLine());
int totalFans = int.Parse(Console.ReadLine());

int sectorA = 0;
int sectorB = 0;
int sectorV = 0;
int sectorG = 0;

for (int fan = 1; fan <= totalFans; fan++)
{
    char sector = char.Parse(Console.ReadLine());
    if (sector == 'A')
    { sectorA++; }
    if (sector == 'B')
    { sectorB++; }
    if (sector == 'V')
    { sectorV++; }
    if (sector == 'G')
    { sectorG++; }
}
double secAPercentage = ((double)sectorA / totalFans) * 100;
double secBPercentage = ((double)sectorB / totalFans) * 100;
double secVPercentage = ((double)sectorV / totalFans) * 100;
double secGPercentage = ((double)sectorG / totalFans) * 100;
int total = sectorA + sectorB + sectorV + sectorG;
double totalPercentage = ((double)total / stadiumCapacity) * 100;

Console.WriteLine($"{secAPercentage:f2}%");
Console.WriteLine($"{secBPercentage:f2}%");
Console.WriteLine($"{secVPercentage:f2}%");
Console.WriteLine($"{secGPercentage:f2}%");
Console.WriteLine($"{totalPercentage:f2}%");