string bookName = Console.ReadLine();
int booksChecked = 0;

string command = Console.ReadLine();

while (command != "No More Books")
{
    string book = command;
    if (book == bookName)
    {
        Console.WriteLine($"You checked {booksChecked} books and found it.");
        break;
    }
    else
    {
        booksChecked++;
    }
    command = Console.ReadLine();
    if (command == "No More Books")
    {
        Console.WriteLine($"The book you search is not here!\nYou checked {booksChecked} books.");
    }
}