string command = Console.ReadLine();
int maxNum = int.MinValue;

while (command != "Stop")
{
    int added = int.Parse(command);
    if (added > maxNum)
    {
        maxNum = added;
    }
    command = Console.ReadLine();
}
Console.WriteLine(maxNum);