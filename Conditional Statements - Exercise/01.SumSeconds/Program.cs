// INPUT
int person01 = int.Parse(Console.ReadLine());
int person02 = int.Parse(Console.ReadLine());
int person03 = int.Parse(Console.ReadLine());

// CALCULATIONS
int toltalTime = person01 + person02 + person03;                    // събирам всички времена в секунди

int timeInMinutes = toltalTime / 60;                                // превръщам секундите в кръгли минути
int timeInSeconds = toltalTime % 60;                                // с модулно деление намирам остатъка в секунди

// OUTPUT
//Console.WriteLine($"The total time of the racers is: {toltalTime} seconds");
//Console.WriteLine($"The total time of the racers is: {timeInMinutes} minutes and 4 seconds");
//Console.WriteLine($"The times is:{timeInMinutes} minutes and {timeInSeconds} seconds");
//Console.WriteLine($"{timeInMinutes}:0{timeInSeconds}")

if (timeInSeconds < 10)
{
    Console.WriteLine($"{timeInMinutes}:0{timeInSeconds}");
}
else
{
    Console.WriteLine($"{timeInMinutes}:{timeInSeconds}");
}