string command = Console.ReadLine();
int minNum = int.MaxValue;

while (command != "Stop")
{
    int added = int.Parse(command);
    if (added < minNum)
    {
        minNum = added;
    }
    command = Console.ReadLine();
}
Console.WriteLine(minNum);