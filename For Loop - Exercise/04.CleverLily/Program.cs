int lilysAge = int.Parse(Console.ReadLine());
double mashinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());


double moneySaved = 0.0;
double birthdayMoney = 10;
int toys = 0;
for (int i = 1; i <= lilysAge; i++)
{

    if (i % 2 != 0)
    {
        toys++;
    }
    else
    {
        moneySaved += (birthdayMoney - 1);
        birthdayMoney += 10;
    }
}
double totalMoney = (toys * toyPrice) + moneySaved;
if (totalMoney >= mashinePrice)
{
    double moneyLeft = totalMoney - mashinePrice;
    Console.WriteLine($"Yes! {moneyLeft:f2}");
}
else
{
    double needed = mashinePrice - totalMoney;
    Console.WriteLine($"No! {needed:f2}");
}