using System;

class Program
{
    static void Main()
    {
        string input;
        int cCount = 0, oCount = 0, nCount = 0;
        string currentWord = "";
        string result = "";

        while ((input = Console.ReadLine()) != "End")
        {
            char symbol = input[0];

            if (!char.IsLetter(symbol))
            {
                continue;
            }

            if (symbol == 'c' && cCount == 0)
            {
                cCount = 1; // Маркираме 'c' като срещнат
            }
            else if (symbol == 'o' && oCount == 0)
            {
                oCount = 1; // Маркираме 'o' като срещнат
            }
            else if (symbol == 'n' && nCount == 0)
            {
                nCount = 1; // Маркираме 'n' като срещнат
            }
            else
            {
                currentWord += symbol;
            }

            if (cCount == 1 && oCount == 1 && nCount == 1)
            {
                result += currentWord + " ";
                currentWord = "";
                cCount = oCount = nCount = 0;
            }
        }

        Console.WriteLine(result);
    }
}