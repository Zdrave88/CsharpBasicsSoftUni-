double deposit = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());
double interest = deposit * (percentage / 100);
double interestPerMonth = interest / 12;
double total = deposit + (months * interestPerMonth);
Console.WriteLine(total);
