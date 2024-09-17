int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());
double moneyDogFood = dogFood * 2.50;
double moneyCatFood = catFood * 4.00;
double total = moneyCatFood + moneyDogFood;
Console.WriteLine($"{total} lv.");