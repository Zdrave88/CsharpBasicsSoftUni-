int number = int.Parse(Console.ReadLine());
int sum = 0;

while (sum < number)
{
    int added = int.Parse(Console.ReadLine());
    sum += added;
}
Console.WriteLine(sum);