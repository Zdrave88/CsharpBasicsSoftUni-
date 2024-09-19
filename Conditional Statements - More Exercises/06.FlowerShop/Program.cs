int magnols = int.Parse(Console.ReadLine());
int zumbuls = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int cactuses = int.Parse(Console.ReadLine());
double presentPrice = double.Parse(Console.ReadLine());

double magnolsPrice = 3.25;
double zumbulsPrice = 4.00;
double rosesPrice = 3.50;
double cactusesPrice = 8.00;

double moneyMade = (magnols*magnolsPrice) + (zumbuls*zumbulsPrice) + (roses*rosesPrice) + (cactuses*cactusesPrice);
double taxes = (moneyMade * 5) / 100;

double finalMoneyAmount = moneyMade - taxes;
//double taxes2 = (moneyMade * 0.05);

double difference = Math.Abs(finalMoneyAmount - presentPrice);
if (finalMoneyAmount >= presentPrice)
{
    Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
}
else
{
    Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva.");
}
