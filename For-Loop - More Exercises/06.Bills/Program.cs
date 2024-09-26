int timeline = int.Parse(Console.ReadLine());

double waterBill = 20.00;
double internetBill = 15.00;

double totalWaterBill = 0.0;
double totalInternetBill = 0.0;
double totalElectricityBill = 0.0;
double totalOtherBill = 0.0;
for (int month = 1; month <= timeline; month++)
{
    double electricBill = double.Parse(Console.ReadLine());
    totalElectricityBill += electricBill;
    totalWaterBill = month * waterBill;
    totalInternetBill = month * internetBill;

    // създавам променлива която съдържа въведения electricBill за конкретният месец от цикъла + вода + интернет  
    double otherBill = (electricBill + waterBill + internetBill) * 1.2;
    totalOtherBill += otherBill;
}

double averageBill = (totalElectricityBill + totalInternetBill + totalWaterBill + totalOtherBill) / timeline;

Console.WriteLine($"Electricity: {totalElectricityBill:f2} lv");
Console.WriteLine($"Water: {totalWaterBill:f2} lv");
Console.WriteLine($"Internet: {totalInternetBill:f2} lv");
Console.WriteLine($"Other: {totalOtherBill:f2} lv");
Console.WriteLine($"Average: {averageBill:f2} lv");