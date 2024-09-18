

string someText = Console.ReadLine();

string password = "s3cr3t!P@ssw0rd";

if (someText != password)                           // != значи едно да е различно от друго
// if (someNumber != 0)                             // тоест ако някое число е различно от 0
{
    Console.WriteLine("Wrong password!");
}

else
{
    Console.WriteLine("Welcome");
}