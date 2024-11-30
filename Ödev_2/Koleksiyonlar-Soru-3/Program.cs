using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("BİR CÜMLE GİRİNİZ");
        string? cumle = Console.ReadLine();

        // Sesli harfler dizisi
        char[] sesliHarfler = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü', 'A', 'E', 'İ', 'I', 'O', 'Ö', 'U', 'Ü' };

        // Sesli harfleri saklayacağımız liste
        List<char> sesliHarfListesi = new List<char>();

        // Cümledeki her bir karakteri kontrol ediyoruz
        foreach (char karakter in cumle)
        {
            if (Array.Exists(sesliHarfler, harf => harf == karakter))
            {
                sesliHarfListesi.Add(karakter);
            }
        }

        // Listeyi sıralıyoruz
        sesliHarfListesi.Sort();

        // Sonuçları ekrana yazdırıyoruz
        Console.WriteLine("Cümledeki sesli harfler sıralı şekilde:");
        foreach (char harf in sesliHarfListesi)
        {
            Console.Write(harf + " ");
        }
    }
}
