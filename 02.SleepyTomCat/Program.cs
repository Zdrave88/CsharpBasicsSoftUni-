int freeDays = int.Parse(Console.ReadLine());
int anualPlayTimeInMinutes = 30000;
int year = 365;
int minutesPerWorkingDay = 63;
int minutesPerDaysOff = 127;

// CALCULATIONS
int workingDays = year - freeDays;
int playPerWorkingDay = workingDays * minutesPerWorkingDay;
int playPerDaysOff = freeDays * minutesPerDaysOff;
int anualPlayTime = playPerWorkingDay + playPerDaysOff;
int minutesToLimit = Math.Abs(anualPlayTimeInMinutes - anualPlayTime);

int hours = minutesToLimit / 60;
int minutes = minutesToLimit % 60;  


if (anualPlayTime >= anualPlayTimeInMinutes)
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
}
else
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{hours} hours and {minutes} minutes less for play"); 
}
