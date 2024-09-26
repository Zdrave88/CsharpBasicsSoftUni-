int numberOfStudents = int.Parse(Console.ReadLine());

int gradeUnder3 = 0;
int gradeUnder4 = 0;
int gradeUnder5 = 0;
int gradeAbove5 = 0;
double average = 0.0;

for (int student = 1; student <= numberOfStudents; student++)
{
    double studentGrade = double.Parse(Console.ReadLine());
    average += studentGrade;
    if (studentGrade >= 2.00 && studentGrade <= 2.99)
    {
        gradeUnder3++;
    }
    else if (studentGrade >= 3.00 && studentGrade <= 3.99)
    {
        gradeUnder4++;
    }
    else if (studentGrade >= 4.00 && studentGrade <= 4.99)
    {
        gradeUnder5++;
    }
    else
    {
        gradeAbove5++;
    }
}
double topStudents = ((double)gradeAbove5 / numberOfStudents) * 100;
double secondBestStudents = ((double)gradeUnder5 / numberOfStudents) * 100;
double thirdBestStudents = ((double)gradeUnder4 / numberOfStudents) * 100;
double failedStudents = ((double)gradeUnder3 / numberOfStudents) * 100;

Console.WriteLine($"Top students: {topStudents:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {secondBestStudents:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {thirdBestStudents:f2}%");
Console.WriteLine($"Fail: {failedStudents:f2}%");
Console.WriteLine($"Average: {average / numberOfStudents:f2}");

