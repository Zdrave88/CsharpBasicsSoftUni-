int moneyRequired = int.Parse(Console.ReadLine());


int moneyCollected = 0;
int averagePaymentByCash = 0;
int averagePaymentByCard = 0;
int moneyViaCash = 0;
int moneyViaCard = 0;
int turns = 1;

string action = Console.ReadLine();
while (true)
{

    if (action == "End")
    {
        Console.WriteLine("Failed to collect required money for charity.");
        break;
    }

    int payment = int.Parse(action);
    if (turns % 2 != 0) // cash
    {
        if (payment > 100)
        {
            Console.WriteLine("Error in transaction!");
        }
        else
        {
            Console.WriteLine("Product sold!");
            moneyCollected += payment;
            averagePaymentByCash++;
            moneyViaCash += payment;
        }
    }
    else // card
    {
        if (payment < 10)
        {
            Console.WriteLine("Error in transaction!");
        }
        else
        {
            Console.WriteLine("Product sold!");
            moneyCollected += payment;
            averagePaymentByCard++;
            moneyViaCard += payment;
        }
    }
    turns++;
    action = Console.ReadLine();
    if (moneyCollected >= moneyRequired)
    {
        Console.WriteLine($"Average CS: {((double)moneyViaCash / averagePaymentByCash):f2}");
        Console.WriteLine($"Average CC: {((double)moneyViaCard / averagePaymentByCard):f2}");
        break;
    }
}