// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("Bir pozitif sayı giriniz");

    string? strNumber = Console.ReadLine();

    if (string.IsNullOrEmpty(strNumber))
    {
        Console.WriteLine("LÜTFEN POZİTİF BİR SAYI GİRİNİZ.");
        continue;
    }
    else if (!strNumber.All(char.IsDigit))
    {
        Console.WriteLine("LÜTFEN SADECE POZİTİF SAYI GİRİNİZ.");
        continue;
    }
    char[] charArrayNumbers = strNumber.ToArray();

    int[] intArrayNumbers = Array.ConvertAll<char, int>(charArrayNumbers, c => int.Parse(c.ToString()));

    int sum = 0;

    for (int i = 0; i < intArrayNumbers.Length; i++)
    {
        sum += intArrayNumbers[i];
    }

    Console.WriteLine("GİRİLEN RAKAMIN RAKAMLARI TOPLAMI= " + sum);

}

