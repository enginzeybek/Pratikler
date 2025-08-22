// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("Ardaşık sayılar giriniz. Sayıları virgülle ayırınız");

    string? strNumbers = Console.ReadLine();

    if (string.IsNullOrEmpty(strNumbers))
    {
        Console.WriteLine("Boş giriş yapılamaz!");
    }

    string[] strArrayNumbers = strNumbers.Split(",");

    List<int> listNumbers = new List<int>();

    foreach (var item in strArrayNumbers)
    {
        if (int.TryParse(item, out int numbers))
        {
            listNumbers.Add(numbers);
        }
        else
        {
            Console.WriteLine("Geçerli sayı giriniz");
        }
    }
    
    int sumOfUnique = listNumbers.Distinct().Sum();

    Console.WriteLine($"Farklı sayıların toplamı: {sumOfUnique}");
}







