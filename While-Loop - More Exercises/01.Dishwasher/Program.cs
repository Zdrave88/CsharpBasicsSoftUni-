int bottles = int.Parse(Console.ReadLine());
int totalMililiters = bottles * 750;
int plateMililiters = 5;
int potMililiters = 15;


int totalPlates = 0;
int totalPots = 0;
int rounds = 1;
string command = Console.ReadLine();

while (true)
{
    if (command == "End")
    {
        Console.WriteLine($"Detergent was enough!\n{totalPlates} dishes and {totalPots} pots were washed.\nLeftover detergent {totalMililiters} ml.");
        break;
    }

    int dishes = int.Parse(command);
    if (rounds % 3 == 0)
    {
        totalPots += dishes;
        totalMililiters -= (dishes * potMililiters);
    }
    else
    {
        totalPlates += dishes;
        totalMililiters -= (dishes * plateMililiters);
    }
    rounds++;

    if (totalMililiters < 0)
    {
        Console.WriteLine($"Not enough detergent, {Math.Abs(totalMililiters)} ml. more necessary!");
        break;
    }
    command = Console.ReadLine();
}