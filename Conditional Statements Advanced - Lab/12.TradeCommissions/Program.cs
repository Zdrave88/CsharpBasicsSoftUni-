string city = Console.ReadLine();
double money = double.Parse(Console.ReadLine());

bool isError = false;
double commision = 0;

if (city == "Sofia")
{ 
    if (money < 0)
    {
        isError = true;
    }
    else if (money <= 500)
    {
        commision = 5;
    }
    else if (money <= 1000)
    {
        commision = 7;
    }
    else if (money <= 10000)
    {
        commision = 8;
    }
    else
    {
        commision = 12;
    }
}
if (city == "Varna")
{
    if (money < 0)
    {
        isError = true;
    }
    else if (money <= 500)
    {
        commision = 4.5;
    }
    else if (money <= 1000)
    {
        commision = 7.5;
    }
    else if (money <= 10000)
    {
        commision = 10;
    }
    else 
    {
        commision = 13;
    }
}
if (city == "Plovdiv")
{
    if (money < 0)
    {
        isError = true;
    }
    else if (money <= 500)
    {
        commision = 5.5;
    }
    else if (money <= 1000)
    {
        commision = 8;
    }
    else if (money <= 10000)
    {
        commision = 12;
    }
    else 
    {
        commision = 14.5;
    }
}
else
{
    isError = true;
}

if (!isError)
{
    double moneyMade = money * (commision / 100);

    Console.WriteLine($"{moneyMade:f2}");
}
else
{
    Console.WriteLine("error");
}