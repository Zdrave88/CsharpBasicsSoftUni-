double petersBudget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ramMemory = int.Parse(Console.ReadLine());

int videoCardsMoneyAmount = videoCards * 250;
double processorsMoneyAmount = (videoCardsMoneyAmount * 0.35) * processors;
double ramMemoryMoneyAmount = (videoCardsMoneyAmount * 0.10) * ramMemory;
double totalMoneyAmount = videoCardsMoneyAmount + processorsMoneyAmount + ramMemoryMoneyAmount;

if (videoCards > processors )
{
   totalMoneyAmount = totalMoneyAmount * 0.85;
}
if (totalMoneyAmount <= petersBudget)
{
    double moneyLeft = petersBudget - totalMoneyAmount;
    Console.WriteLine($"You have {moneyLeft:f2} leva left!");
}
else
{ 
    double moneyNeeded = Math.Abs(totalMoneyAmount - petersBudget);
    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");

}

//Console.WriteLine($"Peter must pay: {videoCardsMoneyAmount} leva for video cards");
//Console.WriteLine($"Peter must pay: {processorsMoneyAmount} leva for processors");
//Console.WriteLine($"Peter must pay: {ramMemoryMoneyAmount} leva for ram memory");
//Console.WriteLine($"To buy everthing Peter must pay: {totalMoneyAmount} leva.");