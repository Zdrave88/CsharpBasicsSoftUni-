//Напишете програма която спрямо времето от денонощието и градусите да препоръча на Виктор какви дрехи да си облече.
//Вашия приятел има различни планове за всеки етап от деня, които изискват и различен външен вид, тях може да видите от таблицата.
//От конзолата се четат точно два реда:
//Градусите - цяло число в интервала [10…42]
//Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"
// "It's {градуси} degrees, get your {облекло} and {обувки}."

int temperature = int.Parse(Console.ReadLine());
string dayTime  = Console.ReadLine();

if (dayTime == "Morning")
{
    if (temperature <= 18)
        Console.WriteLine($"It's {temperature} degrees, get your Sweatshirt and Sneakers.");
    else if (temperature <= 24)
        Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
    else
        Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");

}
else if (dayTime == "Afternoon")
{
    if (temperature <= 18)
        Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
    else if (temperature <= 24)
        Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
    else
        Console.WriteLine($"It's {temperature} degrees, get your Swim Suit and Barefoot.");
}
else 
{
        Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
}