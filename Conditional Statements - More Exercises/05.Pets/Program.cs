
int daysAbsent = int.Parse(Console.ReadLine());
int foodInKilograms = int.Parse(Console.ReadLine());                        // оставена храна
double dogFoodPerDay  = double.Parse(Console.ReadLine());
double catFoodPerDay  = double.Parse(Console.ReadLine());
double turtleFoodInGramsPerDay  = double.Parse(Console.ReadLine());

double dogFoodNeeded = daysAbsent *  dogFoodPerDay;
double catFoodNeeded = daysAbsent * catFoodPerDay;
double turtleFoodNeeded = (daysAbsent * turtleFoodInGramsPerDay) / 1000;
double petFoodPerDay = dogFoodNeeded + catFoodNeeded + turtleFoodNeeded;
if (petFoodPerDay < foodInKilograms)
{
    double foodLeftover = Math.Floor(foodInKilograms - petFoodPerDay);
    Console.WriteLine($"{foodLeftover} kilos of food left.");
}
else
{
    double foodNeeded = Math.Ceiling(petFoodPerDay - foodInKilograms);
    Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
}
