// INPUT
double houseHeight = double.Parse(Console.ReadLine());
double houseLenght = double.Parse(Console.ReadLine());
double roofHeight = double.Parse(Console.ReadLine());

double doorArea = 2 * 1.2;
double windowArea = 2 * 2.25;

// CALCULATIONS
// СТЕНИТЕ НА КЪЩАТА
double sideWalls = (houseHeight * houseLenght) * 2;
double frontAndBackWalls = (houseHeight * houseHeight) * 2;
double sideWallsWithoutWindow = sideWalls - windowArea;
double frontAndBackWallsWithoutDoor = frontAndBackWalls - doorArea;
double allWalls = sideWallsWithoutWindow + frontAndBackWallsWithoutDoor;
double greenPaintNeeded = allWalls / 3.4;

// ПОКРИВЪТ НА КЪЩАТА
double sideRoofParts = (houseHeight * houseLenght) * 2;
double frontAndBackRoofParts = (houseHeight * roofHeight / 2) * 2;
double totalRoofArea = sideRoofParts + frontAndBackRoofParts;
double redPaintNeeded = totalRoofArea / 4.3;



// OUTPUT
//Console.WriteLine("Your house calculations");
//Console.WriteLine($"Your door area is: {doorArea}");
//Console.WriteLine($"Your window area is: {windowArea}");
//Console.WriteLine($"Your side walls area is : {sideWalls}");
//Console.WriteLine($"Your front and back walls area is: {frontAndBackWalls}");
//Console.WriteLine($"Your side walls area without window is: {sideWallsWithoutWindow}");
//Console.WriteLine($"Your side walls area without door is: {frontAndBackWallsWithoutDoor}");
//Console.WriteLine($"Your total area of the side, front and back walls is: {allWalls}");
//Console.WriteLine($"You will need {greenPaintNeeded:f2} litters of green paint");
//Console.WriteLine("Now your roof calculations");
//Console.WriteLine($"Your sides roof area is: {sideRoofParts}");
//Console.WriteLine($"Your front and back roof area is: {frontAndBackRoofParts}");
//Console.WriteLine($"Your total roof area is: {totalRoofArea}");
//Console.WriteLine($"You will need {redPaintNeeded:f2} litters of red paint");
Console.WriteLine($"{greenPaintNeeded:f2}");
Console.WriteLine($"{redPaintNeeded:f2}");