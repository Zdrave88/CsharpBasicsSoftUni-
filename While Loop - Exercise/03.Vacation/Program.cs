
double excursionPrice = double.Parse(Console.ReadLine());
double money = double.Parse(Console.ReadLine());

int spendingMoneyDays = 0;
int savingMoneyDays = 0;
int totalDays = 0;

double moneyNeeded = excursionPrice;
while (money < moneyNeeded)
{
    string action = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());
    if (action == "spend")
    {
        if (amount > money)
        {
            money = 0;
            totalDays++;
        }
        else
        {
            money -= amount;
            totalDays++;
        }
        spendingMoneyDays++;
    }
    else
    {
        money += amount;
        savingMoneyDays++;
        spendingMoneyDays = 0;
        totalDays++;
    }

    if (spendingMoneyDays == 5)
    {
        Console.WriteLine($"You can't save the money.\n{totalDays}");
        break;
    }
}
if (money >= excursionPrice)
{
    Console.WriteLine($"You saved the money for {totalDays} days.");
}