string destination = Console.ReadLine();
//double budget = double.Parse(Console.ReadLine());

while (destination != "End")
{
    double budget = double.Parse(Console.ReadLine());

    double moneyCollected = 0;
    while (moneyCollected < budget)
    {
        double moneyAdded = double.Parse(Console.ReadLine());
        moneyCollected += moneyAdded;
    }
    Console.WriteLine($"Going to {destination}!");
    moneyCollected = 0;

    destination = Console.ReadLine();
    if (destination == "End")
    {
        break;
    }
    //budget = double.Parse(Console.ReadLine());
}