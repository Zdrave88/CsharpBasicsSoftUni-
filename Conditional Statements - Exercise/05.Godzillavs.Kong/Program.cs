double movieBudget = double.Parse(Console.ReadLine());                           // въвеждам реално число - за стойност на бюджета
int movieStatists = int.Parse(Console.ReadLine());                               // въвеждам цяло число - за брой статисти
double moneyPerCloating = double.Parse(Console.ReadLine());                      // въвеждам реално число - за цена на облекло

double decorMoneyAmount = movieBudget * 0.10;                                    // цената за декора е 10% от стойноста на бюджета
double dressMoneyAmount = movieStatists * moneyPerCloating;                      // цената за облекло е брой на статисите * цената за облекло

if (movieStatists > 150)                                                         // АКО статистите са повече от 150
{
    dressMoneyAmount = dressMoneyAmount - (dressMoneyAmount * 0.10);             // цената за облеко е с 10% отстъпка
}

double totalMoneyNeeded = decorMoneyAmount + dressMoneyAmount;                   // общата стойност на необходимите пари за филма

if (totalMoneyNeeded > movieBudget)                                              // АКО общата стойност е ПО ГОЛЯМА от бюджета 
{
    double moneyNeeded = totalMoneyNeeded - movieBudget;                         // необходимите са  общата стойност на необходимите пари - парите  бюджета
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
}
else                                                                             // ИЛИ общата стойност е ПО МАЛКА от бюджета
{                                                                                
    double moneyLeft = movieBudget - totalMoneyNeeded;                           // оставащите пари са парите на бюджета - бщата стойност на необходимите пари
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
}







