int cakeLenght = int.Parse(Console.ReadLine());
int cakeWidth = int.Parse(Console.ReadLine());
int totalCakePieces = cakeLenght * cakeWidth;

string command = Console.ReadLine();
while (command != "STOP")
{
    int pieces = int.Parse(command);
    totalCakePieces -= pieces;
    if (totalCakePieces <= 0)
    {
        int neededPieces = Math.Abs(totalCakePieces);
        Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
        break;
    }
    command = Console.ReadLine();
    if (command == "STOP")
    {

        Console.WriteLine($"{totalCakePieces} pieces are left.");
        break;
    }
}
