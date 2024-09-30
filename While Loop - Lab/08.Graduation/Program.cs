string name = Console.ReadLine();

int klas = 1;
int badGrades = 0;
double averasgeGrade = 0;

while (klas <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());
    if (currentGrade >= 4.00)
    {
        klas++;
        averasgeGrade += currentGrade;
    }
    else
    {
        badGrades++;
        if (badGrades == 2)
        {
            Console.WriteLine($"{name} has been excluded at {klas} grade");
            break;
        }
    }
    if (klas > 12)
    {
        Console.WriteLine($"{name} graduated. Average grade: {(averasgeGrade / 12):f2}");
    }
}