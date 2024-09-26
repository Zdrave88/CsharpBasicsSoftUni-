int periodOfDays = int.Parse(Console.ReadLine());

int medicCount = 7;
int treatedPatiens = 0;
int untreatedPatiens = 0;

for (int day = 1; day <= periodOfDays; day++)
{
    int patiens = int.Parse((Console.ReadLine()));

    if (day % 3 == 0 & untreatedPatiens > treatedPatiens)
    {
        medicCount++;
    }

    if (patiens <= medicCount)
    {
        treatedPatiens += patiens;
    }
    else
    {
        treatedPatiens += medicCount;
        untreatedPatiens += (patiens - medicCount);
    }
}
Console.WriteLine($"Treated patients: {treatedPatiens}.");
Console.WriteLine($"Untreated patients: {untreatedPatiens}.");