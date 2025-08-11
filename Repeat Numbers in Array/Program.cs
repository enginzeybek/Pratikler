// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aralara virgül kullanarak bazı sayıların tekrar ettiği rakamlar giriniz!");
string? strNumbers = Console.ReadLine();
if (string.IsNullOrEmpty(strNumbers))
{
    Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
    return;
}
string[] strArrayNumbers = strNumbers.Split(",");
int[] intArrayNumbers;

try
{
    intArrayNumbers = Array.ConvertAll(strArrayNumbers, int.Parse);
}
catch
{
    Console.WriteLine("Geçersiz sayı girdiniz!");
    return;
}

Dictionary<int, int> countDict = new Dictionary<int, int>();

foreach (int number in intArrayNumbers)
{
    if (countDict.ContainsKey(number))
        countDict[number]++;
    else
        countDict[number] = 1;
}

int maxCount = 0;
int maxNumber = intArrayNumbers[0];
foreach (var kvp in countDict)
{
    if (kvp.Value > maxCount)
    {
        maxCount = kvp.Value;
        maxNumber = kvp.Key;
    }

    Console.WriteLine($"En çok tekrar eden sayı: {maxNumber} ({maxCount} kere)");
}

