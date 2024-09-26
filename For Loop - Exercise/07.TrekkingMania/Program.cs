int totalGroups = int.Parse(Console.ReadLine());

int totalPeople = 0;
int musala = 0;
int monblan = 0;
int kilimandjaro = 0;
int k2 = 0;
int everest = 0;

for (int i = 0; i < totalGroups; i++)
{
    int people = int.Parse(Console.ReadLine());
    totalPeople += people;
    if (people <= 5)
    { musala += people; }
    else if (people <= 12)
    { monblan += people; }
    else if (people <= 25)
    { kilimandjaro += people; }
    else if (people <= 40)
    { k2 += people; }
    else
    { everest += people; }
}

Console.WriteLine($"{(((double)musala / totalPeople) * 100):f2}%");
Console.WriteLine($"{(((double)monblan / totalPeople) * 100):f2}%");
Console.WriteLine($"{(((double)kilimandjaro / totalPeople) * 100):f2}%");
Console.WriteLine($"{(((double)k2 / totalPeople) * 100):f2}%");
Console.WriteLine($"{(((double)everest / totalPeople) * 100):f2}%");
