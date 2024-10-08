int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());
int magicCount = 0;
bool combinationFound = false;

for (int i = num1; i <= num2; i++)
{
    for (int j = num1; j <= num2; j++)
    {
        magicCount++;
        if (i + j == magicNum)
        {
            Console.WriteLine($"Combination N:{magicCount} ({i} + {j} = {magicNum})");
            combinationFound = true;
            break;
        }
    }
    if (combinationFound == true)
    {
        break;
    }
}
if (combinationFound == false)
{
    Console.WriteLine($"{magicCount} combinations - neither equals {magicNum}");
}