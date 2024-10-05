double change = double.Parse(Console.ReadLine());
// превръщам double в int, като го parse и * 100, за да ми излезе цяло число
int changeInStotinki = (int)Math.Round(change * 100);

int coinCount = 0;
while (changeInStotinki > 0)
{
    if (changeInStotinki >= 200)
    {
        changeInStotinki -= 200;
    }
    else if (changeInStotinki >= 100)
    {
        changeInStotinki -= 100;
    }
    else if (changeInStotinki >= 50)
    {
        changeInStotinki -= 50;
    }
    else if (changeInStotinki >= 20)
    {
        changeInStotinki -= 20;
    }
    else if (changeInStotinki >= 10)
    {
        changeInStotinki -= 10;
    }
    else if (changeInStotinki >= 5)
    {
        changeInStotinki -= 5;
    }
    else if (changeInStotinki >= 2)
    {
        changeInStotinki -= 2;
    }
    else if (changeInStotinki >= 1)
    {
        changeInStotinki -= 1;
    }
    coinCount++;
}

Console.WriteLine(coinCount);