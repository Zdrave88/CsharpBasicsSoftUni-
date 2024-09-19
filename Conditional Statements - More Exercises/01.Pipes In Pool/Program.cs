int volumeOfThePoolInLiters = int.Parse(Console.ReadLine());                             // общо литрите обем вода на басейна
int pipe1 = int.Parse(Console.ReadLine());                                               // литрите на час на 1ва тръба
int pipe2 = int.Parse(Console.ReadLine());                                               // литрите на час на 2ра тръба
double hoursAbsent = double.Parse(Console.ReadLine());                                   // времето за работа

                             
double totalLitersFilled = (pipe1 + pipe2) * hoursAbsent;                                // общите литри на двете тръби за 3 часа

double percentagesFilledWater = (totalLitersFilled / volumeOfThePoolInLiters) * 100;     // колко процента е пълен басейна
double pipe1Contribution = (pipe1 * hoursAbsent / totalLitersFilled) * 100;
double pipe2Contribution = (pipe2 * hoursAbsent / totalLitersFilled) * 100;

if (totalLitersFilled <= volumeOfThePoolInLiters)
{
    Console.WriteLine($"The pool is {percentagesFilledWater:f2}% full. Pipe 1: {pipe1Contribution:f2}%. Pipe 2: {pipe2Contribution:f2}%.");
}
else 
{
    double overflowLiters = totalLitersFilled - volumeOfThePoolInLiters;
    Console.WriteLine($"For {hoursAbsent:f2} hours the pool overflows with {overflowLiters:f2} liters.");
}
//Console.WriteLine($"Pipe 1 have filled the pool by {pipe1For3Hours} liters for 3 hours");
//Console.WriteLine($"Pipe 2 have filled the pool by {pipe2For3Hours} liters for 3 hours");
//Console.WriteLine($"The pipes have filled the pool with: {totalLitersFilled} liters for 3 hours");
//Console.WriteLine($"The pool is: {percentagesFilledWater}% full");
//Console.WriteLine($"Pipe 1 have filled the pool by: {number1}%");
//Console.WriteLine($"Pipe 2 have filled the pool by: {number2}%");
//Console.WriteLine($"Pipe 1 have filled the pool by: {number1}%");
//Console.WriteLine($"Pipe 2 have filled the pool by: {number2}%");