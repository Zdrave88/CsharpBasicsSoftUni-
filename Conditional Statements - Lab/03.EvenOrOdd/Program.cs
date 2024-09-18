int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)                            // изпълнявам модулно деление за да проверя остатъка дали е равен на 0
{                                               // тоест дали ако модулно разделя на 2, ако е ==0 е четно, ако не - нечетно 
    Console.WriteLine("even");
}

else

{
    Console.WriteLine("odd");
}