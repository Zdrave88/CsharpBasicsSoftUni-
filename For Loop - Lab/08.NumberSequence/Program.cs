int count = int.Parse(Console.ReadLine());
int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < count; i++)
{
    int added = int.Parse(Console.ReadLine());
    if (added > max)
    {
        max = added;
    }
    if (added < min)
    {
        min = added; ;
    }
}
Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Min number: {min}");