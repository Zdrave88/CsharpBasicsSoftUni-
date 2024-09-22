string city = Console.ReadLine();
double money = double.Parse(Console.ReadLine());

bool isError = false;
double commission = 0;

if (city == "Sofia")
{
    if (money < 0)
    {
        isError = true;
    }
    else if (money <= 500)
    {
        commission = 5;
    }
    else if (money <= 1000)
    {
        commission = 7;
    }
    else if (money <= 10000)
    {
        commission = 8;
    }
    else
    {
        commission = 12;
    }
}
else if (city == "Varna")
{
    if (money < 0)
    {
        isError = true;
    }
    else if (money <= 500)
    {
        commission = 4.5;
    }
    else if (money <= 1000)
    {
        commission = 7.5;
    }
    else if (money <= 10000)
    {
        commission = 10;
    }
    else
    {
        commission = 13;
    }
}
else if (city == "Plovdiv")
{
    if (money < 0)
    {
        isError = true;
    }
    else if (money <= 500)
    {
        commission = 5.5;
    }
    else if (money <= 1000)
    {
        commission = 8;
    }
    else if (money <= 10000)
    {
        commission = 12;
    }
    else
    {
        commission = 14.5;
    }
}
else
{
    isError = true;
}

if (!isError)
{
    double moneyMade = money * (commission / 100);
    Console.WriteLine($"{moneyMade:f2}");
}
else
{
    Console.WriteLine("error");
}