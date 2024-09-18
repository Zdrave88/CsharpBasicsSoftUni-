// INPUT
double numberOfPoints = double.Parse(Console.ReadLine());               // начален брой точки

// CALCULATIONS
double bonusPoints = 0.0;                                               // залагам, че началния брой точки бонус == 0     
if (numberOfPoints <= 100)                                              // ако начален брой точки е по-малък от 100
{
    bonusPoints = 5;                                                    // то тогава добавям към брой точки бонус + 5
}
else if (numberOfPoints <= 1000)                                        // ако начален брой точки е по-малък/равен на 1000
{
    bonusPoints = numberOfPoints * 0.2;                                 // то тогава добавям към началния брой точки бонус + 20% от тях
}
else                                                                    // ако начален брой точки НЕ Е по-малък/равен на 1000, т.е е по-голям от 1000
{
    bonusPoints = numberOfPoints * 0.1;                                 // то тогава добавям към началния брой точки бонус + 10% от тях
}
if (numberOfPoints % 2 == 0)                                            // ако началния брой точки бонус е четно число, деля модулно на 2 и остатъка
{                                                                       // трябва да е 0, т.е е четно число
    bonusPoints = bonusPoints + 1;                                      // добавям + 1 към началния брой точки
}
else if (numberOfPoints % 10 == 5)                                      // ако началния брой точки завършва на 5 деля модулно на 10 и 
{                                                                       // залагам че остатъка трябва да е раве == 5
    bonusPoints = bonusPoints + 2;                                      // добавям + 2 към началния брой точки
}

// OUTPUT
Console.WriteLine(bonusPoints);                                         // викам само точки бонус
Console.WriteLine(numberOfPoints + bonusPoints);                        // викам начален брой точки + точки бонус