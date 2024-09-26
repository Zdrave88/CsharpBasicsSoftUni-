double money = double.Parse(Console.ReadLine());
int yearToLive = int.Parse(Console.ReadLine());

int IvanchoAge = 18;
for (int i = 1800; i <= yearToLive; i++)
{

    if (IvanchoAge % 2 == 0)
    {
        money -= 12000;
    }
    else
    {
        money -= (12000 + (50 * IvanchoAge));
    }
    IvanchoAge++;
}
//moneyToSpend = Math.Abs(moneyToSpend);
//Console.WriteLine($"{moneyToSpend:f2}");
if (money >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
}
else
{
    money = Math.Abs(money);
    Console.WriteLine($"He will need {money:f2} dollars to survive.");