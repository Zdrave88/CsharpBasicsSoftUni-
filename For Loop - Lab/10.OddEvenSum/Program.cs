int n = int.Parse(Console.ReadLine());
int evenSum = 0;
int oddSum = 0;

for (int i = 0; i < n; i++)
{
    int added = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        evenSum += added;
    }
    else
    {
        oddSum += added;
    }
}
if (oddSum == evenSum)
{
    Console.WriteLine($"Yes\nSum = {evenSum}");
}
else
{
    int diff = Math.Abs(oddSum - evenSum);
    Console.WriteLine($"No\nDiff = {diff}");
}
