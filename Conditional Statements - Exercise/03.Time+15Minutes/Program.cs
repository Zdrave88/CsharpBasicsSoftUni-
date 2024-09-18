// INPUT
int inputHour = int.Parse(Console.ReadLine());                       // въвеждам точен час от 0 до 23
int inputMinute = int.Parse(Console.ReadLine());                     // въвеждам точни минути от 0 до 59

// CALCULATIONS
int minutesPlus15Minutes = inputMinute + 15;                         // въведените минути + 15
int hours = inputHour + minutesPlus15Minutes / 60;                   // въведения час + минутите+15 и деля на 60, за да видя колко над 60 минути стават
int minutes = minutesPlus15Minutes % 60;                             // модулно деление за да видя колко минути остават остатък


// OUTPUT
if (hours == 24)                                                     // залагам, че ако часа е 24, да се изпише 0 часа
{
    hours = 0;
}
if (minutes < 10)                                                    // ако минутите са по-малко от 10, тоест едноцифрено число
{
    Console.WriteLine($"{hours}:0{minutes}");                        // да се изпише :0минути (:01, :06, :09)
}
else                                                                 // ако са над десет, тоест двуцифррено число                                                                            
{
    Console.WriteLine($"{hours}:{minutes}");                         // да се изпище без 0, тоест (:11, :54, :31)    
}
