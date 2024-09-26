int counts = int.Parse(Console.ReadLine());

int sum = 0;
int max = int.MinValue;
for (int i = 1; i <= counts; i++)
{
    int added = int.Parse(Console.ReadLine());
    sum += added;

    if (added > max)
    {
        max = added;
    }
}
if ((sum - max) == max)
{
    Console.WriteLine($"Yes\nSum = {max}");
}
else
{
    int diff = Math.Abs((sum - max) - max);
    Console.WriteLine($"No\nDiff = {diff}");
}