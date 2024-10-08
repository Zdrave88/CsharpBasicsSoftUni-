int number = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= number; i++)
{
    int added = int.Parse(Console.ReadLine());
    sum += added;
}
Console.WriteLine($"{((double)sum / number):f2}");