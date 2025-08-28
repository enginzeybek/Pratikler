// See https://aka.ms/new-console-template for more information
Console.WriteLine("Anagram Kontrolü");

Console.Write("İLK KELİMEYİ GİRİNİZ: ");
string? wordOne = Console.ReadLine();

Console.Write("İKİNCİ KELİMEYİ GİRİNİZ: ");
string? wordTwo = Console.ReadLine();

if (string.IsNullOrEmpty(wordOne) || string.IsNullOrEmpty(wordTwo))
{
    Console.WriteLine("LÜTFEN GEÇERLİ BİR KELİME GİRİNİZ");
}
else
{
    Anagram anagram = new Anagram(wordOne, wordTwo);
}


public class Anagram
{
    public Anagram(string _str1, string _str2)
    {
        AreAnagrams(_str1, _str2);
    }
    public void AreAnagrams(string str1, string str2)
    {
        str1 = str1.ToLower();
        str2 = str2.ToLower();

        var sorted1 = String.Concat(str1.OrderBy(c => c));
        var sorted2 = String.Concat(str2.OrderBy(c => c));

        if (sorted1 == sorted2)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}




