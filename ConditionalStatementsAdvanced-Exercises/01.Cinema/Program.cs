// В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони. Има три вида прожекции с билети на различни цени:
// Premiere – премиерна прожекция, на цена 12.00 лева.
// Normal – стандартна прожекция, на цена 7.50 лева.
// Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
// Напишете програма, която чете тип прожекция (стринг), брой редове и брой колони в залата (цели числа), 
// въведени от потребителя, и изчислява общите приходи от билети при пълна зала. 
// Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка.  

string projection = Console.ReadLine();
int cinemaRows = int.Parse(Console.ReadLine());
int cinemaColumns = int.Parse(Console.ReadLine());


int seats = cinemaRows * cinemaColumns;

double price = 0;
switch (projection)
{
    case "Premiere":
        price = 12.00; break;
    case "Normal":
        price = 7.50; break;  
    case "Discount":
        price = 5.00; break;
        
}
double totalAmount = price * seats;
Console.WriteLine($"{totalAmount:f2}");
    
