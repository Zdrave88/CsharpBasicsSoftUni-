int count = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < count; i++)
{
    int added = int.Parse(Console.ReadLine());
    sum += added;
}
Console.WriteLine(sum);