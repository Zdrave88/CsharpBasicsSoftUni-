string season = Console.ReadLine();
string groupOf = Console.ReadLine();
int children = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

string vacantion = string.Empty;
double price = 0;
if (groupOf == "boys")
{
    switch (season)
    {
        case "Winter": vacantion = "Winter vacantion"; price = 9.60; break;
        case "Spring": vacantion = "Spring vacantion"; price = 7.20; break;
        case "Summer": vacantion = "Summer vacantion"; price = 15.0; break;
    }

}
else if (groupOf == "girls")
{
    switch (season)
    {
        case "Winter": vacantion = "Winter vacantion"; price = 9.60; break;
        case "Spring": vacantion = "Spring vacantion"; price = 7.20; break;
        case "Summer": vacantion = "Summer vacantion"; price = 15.0; break;
    }
}
else   // groupOf == "mixed"
{
    switch (season)
    {
        case "Winter": vacantion = "Winter vacantion"; price = 10.00; break;
        case "Spring": vacantion = "Spring vacantion"; price = 9.50; break;
        case "Summer": vacantion = "Summer vacantion"; price = 20.00; break;
    }
}
double totalPrice = children * price * days;

if (children >= 50)
{
    totalPrice = totalPrice - (totalPrice * 0.50);
}
else if (children >= 20 && children < 50)
{
    totalPrice = totalPrice - (totalPrice * 0.15);
}
else if (children >= 10 && children < 20)
{
    totalPrice = totalPrice - (totalPrice * 0.05);
}

string sport = string.Empty;
if (groupOf == "girls")
{
    switch (season)
    {
        case "Winter": sport = "Gymnastics"; break;
        case "Spring": sport = "Athletics"; break;
        case "Summer": sport = "Volleyball"; break;
    }
}
else if (groupOf == "boys")
{
    switch (season)
    {
        case "Winter": sport = "Judo"; break;
        case "Spring": sport = "Tennis"; break;
        case "Summer": sport = "Football"; break;
    }
}
else
{
    switch (season)
    {
        case "Winter": sport = "Ski"; break;
        case "Spring": sport = "Cycling"; break;
        case "Summer": sport = "Swimming"; break;
    }
}
Console.WriteLine($"{sport} {totalPrice:f2} lv.");