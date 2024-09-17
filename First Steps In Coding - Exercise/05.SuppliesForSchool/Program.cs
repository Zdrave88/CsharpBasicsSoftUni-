int pensPackets = int.Parse(Console.ReadLine());
int markersPackets = int.Parse(Console.ReadLine());
int eraserLiquid = int.Parse(Console.ReadLine());
double discountPercentage = double.Parse(Console.ReadLine());

double pensMoney = pensPackets * 5.80;
double markersMoney = markersPackets * 7.20;
double eraserMoney = eraserLiquid * 1.20;
double totalMoney = pensMoney + markersMoney + eraserMoney;
double discount = discountPercentage / 100;
double totalAmount = totalMoney - (totalMoney * discount);
Console.WriteLine(totalAmount);

