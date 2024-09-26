int n = int.Parse(Console.ReadLine()); // Прочитаме броя на двойките
int previousSum = 0;
int currentSum = 0;
int maxDifference = 0;
bool firstPair = true; // Флаг за първата двойка
bool allEqual = true; // Флаг за проверка дали всички двойки са равни

for (int i = 0; i < n; i++)
{
    int firstNumber = int.Parse(Console.ReadLine());
    int secondNumber = int.Parse(Console.ReadLine());
    currentSum = firstNumber + secondNumber;

    if (!firstPair)
    {
        int difference = Math.Abs(currentSum - previousSum);
        if (difference > 0)
        {
            allEqual = false;
        }
        if (difference > maxDifference)
        {
            maxDifference = difference;
        }
    }
    else
    {
        firstPair = false;
    }

    previousSum = currentSum;
}

if (allEqual)
{
    Console.WriteLine($"Yes, value={currentSum}");
}
else
{
    Console.WriteLine($"No, maxdiff={maxDifference}");
}