int totalCargo = int.Parse(Console.ReadLine());

int totalCargoWeight = 0;

int cargoUnder3 = 0;
int cargoUnder11 = 0;
int cargoOver12 = 0;

for (int cargo = 0; cargo < totalCargo; cargo++)
{
    int cargoWeight = int.Parse(Console.ReadLine());
    totalCargoWeight += cargoWeight;

    if (cargoWeight <= 3)
    {
        cargoUnder3 += cargoWeight;
    }
    else if (cargoWeight >= 4 && cargoWeight <= 11)
    {
        cargoUnder11 += cargoWeight;
    }
    else
    {
        cargoOver12 += cargoWeight;
    }
}

double average = ((cargoUnder3 * 200) + (cargoUnder11 * 175) + (cargoOver12 * 120)) / (double)totalCargoWeight;

double busPercentage = ((double)cargoUnder3 / totalCargoWeight) * 100;
double truckPercentage = ((double)cargoUnder11 / totalCargoWeight) * 100;
double trainPercentage = ((double)cargoOver12 / totalCargoWeight) * 100;
Console.WriteLine($"{average:f2}");
Console.WriteLine($"{busPercentage:f2}%");
Console.WriteLine($"{truckPercentage:f2}%");
Console.WriteLine($"{trainPercentage:f2}%");