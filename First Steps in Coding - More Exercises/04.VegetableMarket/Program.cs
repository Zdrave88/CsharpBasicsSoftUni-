double vegetablePrice = double.Parse(Console.ReadLine());
double fruitPrice = double.Parse(Console.ReadLine());
double vegetableKilograms = double.Parse(Console.ReadLine());
double fruitKilograms = double.Parse(Console.ReadLine());

double vegetableMoney = vegetablePrice * vegetableKilograms;
double fruitMoney = fruitPrice * fruitKilograms;
double total = vegetableMoney + fruitMoney;
double totalEuro = total / 1.94;
Console.WriteLine($"{totalEuro:f2}");