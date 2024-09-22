int temperature = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

string outfit = "";
string shoes = "";
switch (dayTime)
{
    case "Morning":
        if (temperature <= 18)
           {
               outfit = "Sweatshirt";
               shoes = "Sneakers";
           }
        else if (temperature <= 24)
           {
               outfit = "Shirt";
               shoes = "Moccasins";
           }
        else
           {
               outfit = "T-Shirt";
               shoes = "Sandals";
           }
        break;

    case "Afternoon":
        if (temperature <= 18)
           {
              outfit = "Shirt";
              shoes = "Moccasins";
           }
        else if (temperature <= 24)
           {
              outfit = "T-Shirt";
              shoes = "Sandals";
           }
    else
           {
              outfit = "Swim Suit";
              shoes = "Barefoot";
           }
        break;

     case "Evening":
                Console.WriteLine();
        break;

     default:

     break;
 }

Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
