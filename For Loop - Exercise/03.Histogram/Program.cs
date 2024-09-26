int totalNumbers = int.Parse(Console.ReadLine());

int p1 = 0; int p2 = 0; int p3 = 0; int p4 = 0; int p5 = 0;

for (int i = 0; i < totalNumbers; i++)
{
    int added = int.Parse(Console.ReadLine());
    if (added < 200)
    { p1++; }
    else if (added >= 200 && added <= 399)
    { p2++; }
    else if (added >= 400 && added <= 599)
    { p3++; }
    else if (added >= 600 && added <= 799)
    { p4++; }
    else
    { p5++; }
}
double p1p = ((double)p1 / totalNumbers) * 100;
double p2p = ((double)p2 / totalNumbers) * 100;
double p3p = ((double)p3 / totalNumbers) * 100;
double p4p = ((double)p4 / totalNumbers) * 100;
double p5p = ((double)p5 / totalNumbers) * 100;
Console.WriteLine($"{p1p:f2}%");
Console.WriteLine($"{p2p:f2}%");
Console.WriteLine($"{p3p:f2}%");
Console.WriteLine($"{p4p:f2}%");
Console.WriteLine($"{p5p:f2}%");
