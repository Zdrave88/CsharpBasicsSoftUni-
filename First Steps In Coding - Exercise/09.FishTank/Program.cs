int lengh = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double usedPercent = double.Parse(Console.ReadLine());
double aquariumArea = lengh * width * height;
double aquariumLitters = aquariumArea / 1000;
double percent = usedPercent / 100;
double needed = aquariumLitters * (1 - percent);
Console.WriteLine(needed);