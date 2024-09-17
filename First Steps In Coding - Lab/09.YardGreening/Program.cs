double squareMeters = double.Parse(Console.ReadLine());
double totalPrice = (squareMeters * 7.61);
double discount = (squareMeters * 7.61) * 0.18;
Console.WriteLine($"The final price is: {totalPrice - discount} lv.");
Console.WriteLine($"The discount is: {discount} lv.");