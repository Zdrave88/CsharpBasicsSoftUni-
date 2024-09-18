
double excursion = double.Parse(Console.ReadLine());                             // цената на екскурцията
int amountOfPuzzles = int.Parse(Console.ReadLine());                             // брой пъзели
int amountOfDolls = int.Parse(Console.ReadLine());                               // брой кукли
int amountOfTeddyBears = int.Parse(Console.ReadLine());                          // брой мечета
int amountOfMinions = int.Parse(Console.ReadLine());                             // брой идиоти
int amountOfrucks = int.Parse(Console.ReadLine());                               // брой камиончета

double moneyFromPuzzles = amountOfPuzzles * 2.6;                                 // цена на един пъзел
double moneyFromDolls = amountOfDolls * 3;                                       // цена на една кукла
double moneyFromTeddyBears = amountOfTeddyBears * 4.1;                           // цена на един мечок
double moneyFromMinions = amountOfMinions * 8.20;                                // цена на един идиот
double moneyFromTrucks = amountOfrucks * 2;                                      // цена на един камион

double totalToys = amountOfPuzzles + amountOfDolls + amountOfTeddyBears + amountOfMinions + amountOfrucks;          // общ брой играчки
double totalMoney = moneyFromPuzzles + moneyFromDolls + moneyFromTeddyBears + moneyFromMinions + moneyFromTrucks;   // обща цена на играчките

if (totalToys >= 50)                                                             // ако играчките са 50 или повече
{
    totalMoney = totalMoney * 0.75;                                              // прави се отстъпка 25%, затова *0.75
}
double moneyForRent = totalMoney * 0.10;                                         // наема е 10% от обща цена на играчките
double pureAmount = totalMoney - moneyForRent;                                   // чистата печалба е обща цена на играчките - наема
double money = pureAmount - excursion;                                           // парите, които остват след всички разходи

if (pureAmount >= excursion)                                                     // ако чистата печалба е по-голяма от цената на екскурцията
{
    double moneyLeft = pureAmount - excursion;                                   // вадя цената на екскурцията от чистата печалба
    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");                          // ако стигат
}
else if (pureAmount < excursion)                                                 // ако цената на екскурцията е по-голяма от чистата печалба
{
    double moneyNeeded = excursion - pureAmount;                                 // вадя от чистата печалба цената на екскурцията 
    Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");         // не достигат
}