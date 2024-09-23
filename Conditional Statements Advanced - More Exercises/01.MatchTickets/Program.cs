double budget = double.Parse(Console.ReadLine());
string ticket = Console.ReadLine();
int people = int.Parse(Console.ReadLine());

double VIP = 499.99;
double normal = 249.99;

double transport = 0.0;
if (people < 5)
{
    transport = budget * 0.75;
    budget -= transport;
}
else if (people >= 5 && people < 10)
{
    transport = budget * 0.60;
    budget -= transport;
}
else if (people >= 10 && people < 25)
{
    transport = budget * 0.50;
    budget -= transport;
}
else if (people >= 25 && people < 50)
{
    transport = budget * 0.40;
    budget -= transport;
}
else
{
    transport = budget * 0.25;
    budget -= transport;
}
double money = 0.0;
if (ticket == "VIP")
{
    money = people * VIP;
}
else
{
    money = people * normal;
}

if (budget >= money)
{
    double left = budget - money;
    Console.WriteLine($"Yes! You have {left:f2} leva left.");
}
else
{
    double need = money - budget;
    Console.WriteLine($"Not enough money! You need {need:f2} leva.");

}