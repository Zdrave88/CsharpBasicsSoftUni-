int floors = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());
int lastFloor = floors;

for (int i = floors; i >= 1; i--)
{
    if (i % 2 == 0 && i != floors)      // офиси
    {
        //floors--;
        floors = i;
        for (int j = 0; j < rooms; j++)
        {
            Console.Write($"O{floors}{j} ");
        }
        Console.WriteLine();
    }

    else if (i % 2 != 0 && i != lastFloor)               // апартаменти
    {
        //floors--;
        floors = i;
        for (int j = 0; j < rooms; j++)
        {
            Console.Write($"A{floors}{j} ");
        }
        Console.WriteLine();
    }

    if (i == lastFloor)    // големи апартаменти
    {
        for (int j = 0; j < rooms; j++)
        {
            Console.Write($"L{floors}{j} ");
        }
        Console.WriteLine();
    }
}
