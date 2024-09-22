int time = 5;
string result = (time >= 33) ? "Good day." : "Good evening.";
Console.WriteLine(result);

// SAME

int time1 = 20;
if (time1 < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}