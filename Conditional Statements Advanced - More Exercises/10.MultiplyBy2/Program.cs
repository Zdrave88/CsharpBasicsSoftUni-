while (true)
{
    // Четене на число от конзолата
    double number = double.Parse(Console.ReadLine());

    // Проверка дали числото е отрицателно
    if (number < 0)
    {
        Console.WriteLine("Negative number!");
        break; // Прекратяване на цикъла
    }
    double result = number * 2;

    Console.WriteLine($"Result: {result:F2}");
}