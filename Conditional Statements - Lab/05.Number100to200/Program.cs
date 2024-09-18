int number = int.Parse(Console.ReadLine());

if (number < 100)                                      // ако number е по-малко от 100 печати "Less than 100"
{
    Console.WriteLine("Less than 100");
}
else if (number > 200)                                 // ако number е по-голямо от 200 печати "Greater than 200" 
{
    Console.WriteLine("Greater than 200");
}
else                                                   // ако е нито едно от двете отгоре печати "Between 100 and 200"
{
    Console.WriteLine("Between 100 and 200");
}