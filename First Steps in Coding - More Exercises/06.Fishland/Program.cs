double skumriyaPrice = double.Parse(Console.ReadLine());
double cacaPrice = double.Parse(Console.ReadLine());
double palamudAmount = double.Parse(Console.ReadLine());
double safridAmount = double.Parse(Console.ReadLine());
double midiAmount = double.Parse(Console.ReadLine());
// Паламуд – 60% по-скъп от скумрията
// Сафрид – 80% по-скъп от цацата
// Миди - 7.50лв/кг
// Изчисляваме колко струва паламуда и сафрида спрямо инфото отгоре
double palamudPrice = skumriyaPrice + (skumriyaPrice * 0.60);   // 6.90 + (6.90 * 0.60) = 11.04
double safridPrice = cacaPrice + (cacaPrice * 0.80);            // 4.20 + (4.20 * 0.80) = 7.56
// Изчисляваме колко струва всичко
double moneyForPalamud = palamudAmount * palamudPrice;
double moneyForSafrid = safridAmount * safridPrice;
double moneyForMidi = midiAmount * 7.50;
// Всичко общо
double total = moneyForPalamud + moneyForSafrid + moneyForMidi;
Console.WriteLine($"{total:f2}");