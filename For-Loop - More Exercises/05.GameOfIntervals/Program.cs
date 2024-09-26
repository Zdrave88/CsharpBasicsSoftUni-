int gameRounds = int.Parse(Console.ReadLine());

int set1 = 0;
int set2 = 0;
int set3 = 0;
int set4 = 0;
int set5 = 0;
int invalid = 0;

double score = 0;

for (int round = 1; round <= gameRounds; round++)
{
    int addedNumber = int.Parse(Console.ReadLine());

    if (addedNumber < 0 || addedNumber > 50)
    {
        score /= 2;
        invalid++;
    }


    if (addedNumber >= 0 && addedNumber <= 9)
    {
        score += (addedNumber * 0.20);
        set1++;
    }

    else if (addedNumber >= 10 && addedNumber <= 19)
    {
        score += (addedNumber * 0.30);
        set2++;
    }

    else if (addedNumber >= 20 && addedNumber <= 29)
    {
        score += (addedNumber * 0.40);
        set3++;
    }

    else if (addedNumber >= 30 && addedNumber <= 39)
    {
        score += 50;
        set4++;
    }

    else if (addedNumber >= 40 && addedNumber <= 50)
    {
        score += 100;
        set5++;
    }

}

double set1percentage = ((double)set1 / gameRounds) * 100;
double set2percentage = ((double)set2 / gameRounds) * 100;
double set3percentage = ((double)set3 / gameRounds) * 100;
double set4percentage = ((double)set4 / gameRounds) * 100;
double set5percentage = ((double)set5 / gameRounds) * 100;
double invalidPercentage = ((double)invalid / gameRounds) * 100;

Console.WriteLine($"{score:f2}");
Console.WriteLine($"From 0 to 9: {set1percentage:f2}%");
Console.WriteLine($"From 10 to 19: {set2percentage:f2}%");
Console.WriteLine($"From 20 to 29: {set3percentage:f2}%");
Console.WriteLine($"From 30 to 39: {set4percentage:f2}%");
Console.WriteLine($"From 40 to 50: {set5percentage:f2}%");
Console.WriteLine($"Invalid numbers: {invalidPercentage:f2}%");
