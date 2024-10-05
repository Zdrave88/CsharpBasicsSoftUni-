string command = Console.ReadLine();

int totalSteps = 0;
int targetSteps = 10000;
while (command != "Going home")
{
    int steps = int.Parse(command);
    totalSteps += steps;

    if (totalSteps >= targetSteps)
    {
        Console.WriteLine($"Goal reached! Good job!\n{(totalSteps - targetSteps)} steps over the goal!");
        break;
    }
    command = Console.ReadLine();
}
if (command == "Going home")
{
    int goingHomeSteps = int.Parse(Console.ReadLine());
    totalSteps += goingHomeSteps;
    if (totalSteps >= targetSteps)
    {
        Console.WriteLine($"Goal reached! Good job!\n{(totalSteps - targetSteps)} steps over the goal!");
    }
    else
    {
        Console.WriteLine($"{Math.Abs(targetSteps - totalSteps)} more steps to reach goal.");
    }
}