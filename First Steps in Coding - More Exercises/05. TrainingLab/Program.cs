double lenght = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double lenghtcm = lenght * 100;
double widtcm = (width * 100) - 100;
double desks = Math.Floor(widtcm / 70);
double rows = Math.Floor(lenghtcm / 120);
double allDesks = (desks * rows) - 3;
Console.WriteLine(allDesks);
