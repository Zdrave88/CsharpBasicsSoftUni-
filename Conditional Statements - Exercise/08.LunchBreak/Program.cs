string nameOfTheSeries = Console.ReadLine();
double seriesDuration = double.Parse(Console.ReadLine());
double lunchBreakDuration = double.Parse(Console.ReadLine());

double timeForLunch = lunchBreakDuration * 1/8;
double timeForRest = lunchBreakDuration  * 1/4;

double freeTime = timeForLunch + timeForRest;

double timeLeftAfterRestAndLunch = lunchBreakDuration - timeForRest - timeForLunch;

if (timeLeftAfterRestAndLunch >= seriesDuration)
{
    double timeLeft = timeLeftAfterRestAndLunch - seriesDuration;
    Console.WriteLine($"You have enough time to watch {nameOfTheSeries} and left with {Math.Ceiling(timeLeft)} minutes free time.");
}
else
{
    double timeNeeded = seriesDuration - timeLeftAfterRestAndLunch;
    Console.WriteLine($"You don't have enough time to watch {nameOfTheSeries}, you need {Math.Ceiling(timeNeeded)} more minutes.");

}

//Console.WriteLine(timeLeftAfterRestAndLunch);









//Console.WriteLine($"You have {timeForLunch} minutes for lunch");
//Console.WriteLine($"You have {timeForRest} minutes for rest");
//Console.WriteLine($"You have {timeLeftAfterRestAndLunch} minutes rest to watch");
