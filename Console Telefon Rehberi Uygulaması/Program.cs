using System.Security.Cryptography.X509Certificates;

Dictionary<string,int> telGuide = new Dictionary<string, int>();

telGuide.Add("ENGİN ZEYBEK",1111122);
telGuide.Add("ASLI TAÇ",1111123);
telGuide.Add("BERK TERK",1111124);
telGuide.Add("ZEYNEP BAYRAK",1111125);
telGuide.Add("TUĞÇE YILMAZ",1112225);

while(true)
{
    Console.WriteLine("LÜTFEN YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ");

    Console.Write(" (1) Yeni Numara Kaydetmek (2) Rehberi Listelemek (3) Varolan Numarayı Silmek (4) Varolan Numarayı Güncelleme (5) Rehberde Arama Yapmak﻿");

int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine("İSİM GİRİNİZ");
    string? name = Console.ReadLine();

    Console.WriteLine("TELEFON GİRİNİZ");
    int phone = Convert.ToInt32(Console.ReadLine());

    if(name != null)
    {
        telGuide.Add(name,phone);
    }
}
else if (choice == 2)
{
    foreach (var item in telGuide)
    {
        Console.WriteLine($"İsim: {item.Key}, Telefon: {item.Value}");
    }    
}
else if(choice == 3)
{
    string Normalize(string input)
    {
        return input
        .Replace("İ", "I").Replace("ı", "i")
        .Replace("Ğ", "G").Replace("ğ", "g")
        .Replace("Ü", "U").Replace("ü", "u")
        .Replace("Ş", "S").Replace("ş", "s")
        .Replace("Ç", "C").Replace("ç", "c")
        .Replace("Ö", "O").Replace("ö", "o");
    }

    string test = "TUĞÇE YILMAZ";
    Console.WriteLine(Normalize(test));

    Console.WriteLine("SİLMEK İSTEDİĞİNİZ İSMİ GİRİNİZ");
    string? deleteName = Console.ReadLine()?.Trim();

    if (!string.IsNullOrEmpty(deleteName))
    {
        deleteName = Normalize(deleteName);

        var keyToRemove = telGuide.Keys
        .Select(Normalize)
        .FirstOrDefault(key => key.Equals(deleteName, StringComparison.OrdinalIgnoreCase));

        if (keyToRemove != null)
        {
            telGuide.Remove(keyToRemove);
            Console.WriteLine($"{deleteName} isimli kişi rehberden  başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Rehberde böyle bir isim bulunamadı.");
        }
    }

    
}
else if(choice == 4)
{
    Console.WriteLine("GÜNCELLEMEK İSTEDİĞİNİZ NUMARAYI GİRİNİZ");
    string updatedName = Console.ReadLine();

    if (updatedName != null)
    {
        if (telGuide.ContainsKey(updatedName))
        {
            Console.WriteLine($"{updatedName} için yeni telefon numarasını giriniz:");
            if (int.TryParse(Console.ReadLine(), out int newPhone))
            {
                telGuide[updatedName] = newPhone; 

                Console.WriteLine($"{updatedName} güncellendi. Yeni numarası: {newPhone}");
            }
            else
            {
                Console.WriteLine("Geçerli bir telefon numarası giriniz");
            }
        }
    }
}
else if(choice == 5)
{
    Console.WriteLine("ARAMAK İSTEDİĞİNİZ İSMİ GİRİNİZ");
    string findingNumber = Console.ReadLine();

    if (!string.IsNullOrEmpty(findingNumber))
    {
        if (telGuide.ContainsKey(findingNumber)) 
        {
            Console.WriteLine($"Kişi: {findingNumber}, Telefon Numarası: {telGuide[findingNumber]}");
        }
        else
        {
        Console.WriteLine($"{findingNumber} isimli kişi rehberde bulunamadı.");
        }
    }
    else
    {
        Console.WriteLine("Geçerli bir isim giriniz.");
    }
    
}
}



