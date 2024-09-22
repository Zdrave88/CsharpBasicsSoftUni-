string month = Console.ReadLine().ToLower();
int nights = int.Parse(Console.ReadLine());

double studioPrice = 0;
double apartmentPrice = 0;

switch (month)
{
    case "may":
    case "october":
        studioPrice = 50.0;
        apartmentPrice = 65.0;
        if (nights > 7 && nights <= 14)
        {
            studioPrice *= 0.95; // 5% discount
        }
        else if (nights > 14)
        {
            studioPrice *= 0.70; // 30% discount
        }
        break;
    case "june":
    case "september":
        studioPrice = 75.20;
        apartmentPrice = 68.70;
        if (nights > 14)
        {
            studioPrice *= 0.80; // 20% discount
        }
        break;
    case "july":
    case "august":
        studioPrice = 76.0;
        apartmentPrice = 77.0;
        break;
    default:
        Console.WriteLine("Invalid month");
        return;
}

if (nights > 14)
{
    apartmentPrice *= 0.90; // 10% discount
}

double totalStudioPrice = studioPrice * nights;
double totalApartmentPrice = apartmentPrice * nights;

Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");