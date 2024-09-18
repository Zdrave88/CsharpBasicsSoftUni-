// INPUT

double recordInSeconds = double.Parse(Console.ReadLine());                         // рекорда в секунди
double distanceToSwimInMeters = double.Parse(Console.ReadLine());                  // разстоянието за плуване в метри
double metersSwimmedPerSeconds = double.Parse(Console.ReadLine());                 // метри изплувани за 1 секунда
int waterResistancePerMeter = 15;                                                  // на всеки 15 метра се забавя с 12.5 секунди 
double resistancePerSecond = 12.5;                                                 // стойноста на забавянето

// CALCULATIONS
double timeForSwiming = distanceToSwimInMeters * metersSwimmedPerSeconds;          // времето за плуване на разстоянието
double waterResistance = Math.Floor(distanceToSwimInMeters / waterResistancePerMeter) * resistancePerSecond; // изчислява колко е забавянето
double totalSwimmingTime = timeForSwiming + waterResistance;                       // тоталното време за плуване със сметнато забавяне 

if (totalSwimmingTime < recordInSeconds)                                           // АКО тоталното време за плуване е ПО МАЛКО  от рекорда
{
    
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalSwimmingTime:f2} seconds.");
}
else                                                                               // АКО тоталното време за плуване е ПО ГОЛЯМО от рекорда
{
    double timeNeeded = totalSwimmingTime - recordInSeconds;                       // намирам времето с което надвишавам рекорда
    Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
}



// OUPUT
//Console.WriteLine($"Ivan needs to swim for: {timeForSwiming} seconds.");
//Console.WriteLine($"Ivan will be added 12.5 seconds for every 15 meters he swam, and tgat will add: {waterResistance} seconds to his time.");
//Console.WriteLine($"Ivan total time for swimming is: {totalSwimmingTime} seconds.");