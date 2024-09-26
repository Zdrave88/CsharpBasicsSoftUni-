int count = int.Parse(Console.ReadLine());
int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < count; i++)
{
    int left = int.Parse(Console.ReadLine());
    leftSum += left;
}
for (int i = 0; i < count; i++)
{
    int right = int.Parse(Console.ReadLine());
    rightSum += right;
}
if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {rightSum}");
}
else
{
    int diff = Math.Abs(leftSum - rightSum);
    Console.WriteLine($"No, diff = {diff}");
}