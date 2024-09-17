int anualFee = int.Parse(Console.ReadLine());
double shoes = anualFee * 0.6;
double jersey = shoes * 0.8;
double ball = jersey * 0.25;
double accesoaries = ball * 0.20;
double total = anualFee + shoes + jersey + ball + accesoaries;
Console.WriteLine(total);