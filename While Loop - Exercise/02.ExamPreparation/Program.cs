int badGrades = int.Parse(Console.ReadLine());
string command = Console.ReadLine();


double averageGrade = 0.0;
int tasksCompleted = 0;
int tasksFailed = 0;
string lastTask = "";

while (command != "Enough")
{

    string task = command;
    double grade = double.Parse(Console.ReadLine());
    if (grade > 4.00)
    {
        tasksCompleted++;
        averageGrade += grade;
    }
    else
    {
        tasksFailed++;
        tasksCompleted++;
        averageGrade += grade;
    }

    lastTask = task;

    if (tasksFailed == badGrades)
    {
        Console.WriteLine($"You need a break, {tasksFailed} poor grades.");
        break;
    }

    command = Console.ReadLine();
}

if (command == "Enough")
{
    Console.WriteLine($"Average score: {(averageGrade / tasksCompleted):f2}");
    Console.WriteLine($"Number of problems: {tasksCompleted}");
    Console.WriteLine($"Last problem: {lastTask}");
}