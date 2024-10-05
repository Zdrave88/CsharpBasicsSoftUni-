int freeSpaceWidth = int.Parse(Console.ReadLine());
int freeSpaceLenght = int.Parse(Console.ReadLine());
int freeSpaceHeight = int.Parse(Console.ReadLine());

int cubicMeterFreeSpace = freeSpaceWidth * freeSpaceLenght * freeSpaceHeight;

string command = Console.ReadLine();
while (command != "Done" && cubicMeterFreeSpace > 0)
{
    int boxSize = int.Parse(command);
    cubicMeterFreeSpace -= boxSize;

    command = Console.ReadLine();
}
if (command == "Done")
{
    Console.WriteLine($"{cubicMeterFreeSpace} Cubic meters left.");
}
else
{
    Console.WriteLine($"No more free space! You need {Math.Abs(cubicMeterFreeSpace)} Cubic meters more.");
}