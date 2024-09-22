string fruit = Console.ReadLine();
string dayOfWeek  = Console.ReadLine(); 
double fruitAmount = double.Parse(Console.ReadLine());

double fruitPrice = 0;
bool isError = false;   

if (dayOfWeek == "Monday")
{
    switch (fruit)
    {
        case "banana": fruitPrice = 2.50; break;
        case "apple": fruitPrice = 1.20; break;
        case "orange": fruitPrice = 0.85; break;
        case "grapefruit": fruitPrice = 1.45; break;
        case "kiwi": fruitPrice = 2.70; break;
        case "pineapple": fruitPrice = 5.50; break;
        case "grapes": fruitPrice = 3.85; break;
    }
}
else if (dayOfWeek == "Tuesday")
    switch (fruit)
    {
        case "banana": fruitPrice = 2.50; break;
        case "apple": fruitPrice = 1.20; break;
        case "orange": fruitPrice = 0.85; break;
        case "grapefruit": fruitPrice = 1.45; break;
        case "kiwi": fruitPrice = 2.70; break;
        case "pineapple": fruitPrice = 5.50; break;
        case "grapes": fruitPrice = 3.85; break;
    }
else if (dayOfWeek == "Wednesday")
    switch (fruit)
    {
        case "banana": fruitPrice = 2.50; break;
        case "apple": fruitPrice = 1.20; break;
        case "orange": fruitPrice = 0.85; break;
        case "grapefruit": fruitPrice = 1.45; break;
        case "kiwi": fruitPrice = 2.70; break;
        case "pineapple": fruitPrice = 5.50; break;
        case "grapes": fruitPrice = 3.85; break;
    }
else if (dayOfWeek == "Thursday")
    switch (fruit)
    {
        case "banana": fruitPrice = 2.50; break;
        case "apple": fruitPrice = 1.20; break;
        case "orange": fruitPrice = 0.85; break;
        case "grapefruit": fruitPrice = 1.45; break;
        case "kiwi": fruitPrice = 2.70; break;
        case "pineapple": fruitPrice = 5.50; break;
        case "grapes": fruitPrice = 3.85; break;
    }
else if (dayOfWeek == "Friday")
    switch (fruit)
    {
        case "banana": fruitPrice = 2.50; break;
        case "apple": fruitPrice = 1.20; break;
        case "orange": fruitPrice = 0.85; break;
        case "grapefruit": fruitPrice = 1.45; break;
        case "kiwi": fruitPrice = 2.70; break;
        case "pineapple": fruitPrice = 5.50; break;
        case "grapes": fruitPrice = 3.85; break;
    }
else if (dayOfWeek == "Saturday")
    switch (fruit)
    {
        case "banana": fruitPrice = 2.70; break;
        case "apple": fruitPrice = 1.25; break;
        case "orange": fruitPrice = 0.90; break;
        case "grapefruit": fruitPrice = 1.60; break;
        case "kiwi": fruitPrice = 3.00; break;
        case "pineapple": fruitPrice = 5.60; break;
        case "grapes": fruitPrice = 4.20; break;
    }
else if (dayOfWeek == "Sunday")
    switch (fruit)
    {
        case "banana": fruitPrice = 2.70; break;
        case "apple": fruitPrice = 1.25; break;
        case "orange": fruitPrice = 0.90; break;
        case "grapefruit": fruitPrice = 1.60; break;
        case "kiwi": fruitPrice = 3.00; break;
        case "pineapple": fruitPrice = 5.60; break;
        case "grapes": fruitPrice = 4.20; break;
    }
else
{
    Console.WriteLine("error");
    isError = true;
}
if (!isError)
{
    double totalCost = fruitPrice * fruitAmount;

    Console.WriteLine($"{totalCost:f2}");

}
