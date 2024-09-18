int number1 = int.Parse(Console.ReadLine());         // 5
int number2 = int.Parse(Console.ReadLine());         // 1

if (number1 > number2)                               // ако number1 > number2 (ако 1 е по-голямо от 2)
{
    Console.WriteLine(number1);                      // отпечати number1  тоест 5
}
else                                                 // иначе, ако number2 > number1 (ако 2 е по-голямо от 1),
{ 
    Console.WriteLine(number2);                      // отпечати number2  
}
