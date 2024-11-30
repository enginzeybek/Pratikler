int[] sayi = new int[20];


for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"{i + 1}. sayıyı giriniz:");
    sayi[i] = int.Parse(Console.ReadLine());
}


Array.Sort(sayi);
int[] minValues = { sayi[0], sayi[1], sayi[2] }; 
int[] maxValues = { sayi[17], sayi[18], sayi[19] }; 


double avgMinValue = (double)(minValues[0] + minValues[1] + minValues[2]) / 3;
double avgMaxValue = (double)(maxValues[0] + maxValues[1] + maxValues[2]) / 3;
double avgSum = avgMinValue + avgMaxValue;


Console.WriteLine("En küçük sayıların ortalaması: " + avgMinValue);
Console.WriteLine("En büyük sayıların ortalaması: " + avgMaxValue);
Console.WriteLine("Ortalamaların toplamı: " + avgSum);
