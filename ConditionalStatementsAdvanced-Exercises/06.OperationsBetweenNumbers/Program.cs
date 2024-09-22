// Входни данни 
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());  // + - * / или %
// 2 Проверявам дали оператора е "+ , - , *" 
// проверявам дали резултата е четен "{резултат % 2 = 0} ? " или нечетен
// отпечатвам "{N1} {оператор} {N2} = {резултат}" 
if (operation == '+' || operation == '-' || operation == '*')
{
    int result = 0;
    string evenOrOdd = "odd";
    switch (operation)
    {
        case '+': result = number1 + number2; break;
        case '-': result = number1 - number2; break;
        case '*': result = number1 * number2; break;
    }
    if (result % 2 == 0)
        evenOrOdd = "even";
    Console.WriteLine($"{number1} {operation} {number2} = {result} - {evenOrOdd}");
}
// 3 Проверявам дали оператора е " / " или "%"
// проверявам дали {N2} == 0, ако да
// отпечатвам 	"Cannot divide {N1} by zero"
else
{
    if (number2 == 0)
    {
        Console.WriteLine($"Cannot divide {number1} by zero");
    }
    else if (operation == '/')
    {
        double result = (double)number1 / number2;
        Console.WriteLine($"{number1} {operation} {number2} = {result:f2}");

    }
    else
    {
        int result = number1 % number2;
        Console.WriteLine($"{number1} % {number2} = {result}");
    }
}

        
// 