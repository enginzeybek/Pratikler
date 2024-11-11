// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region 1.Çözüm

/*Console.WriteLine("POZİTİF BİR TAM SAYI GİRİNİZ");

int PSayi = Convert.ToInt32(Console.ReadLine());

int[] sayilar = new int[PSayi];

for (int i = 0; i < PSayi; i++)
{
    Console.WriteLine((i + 1) + ". sayıyı giriniz:");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (var item in sayilar)
{
    if (item % 2 == 0)
    {
        Console.WriteLine("Çift sayılar: " + item);
    }
}*/
#endregion


#region 2.Çözüm

/*Console.WriteLine("POZİTİF İLK SAYIYI GİR");
int numbern = int.Parse(Console.ReadLine());

Console.WriteLine("POZİTİF İKİNCİ SAYIYI GİR");
int numberm = int.Parse(Console.ReadLine());

int[] kume = new int[numbern];

for (int i = 0; i < numbern; i++)
{
    Console.WriteLine((i + 1) + ". sayıyı giriniz");
    kume[i] = int.Parse(Console.ReadLine());
}

foreach (var item in kume)
{
    if (item % numberm == 0 || item == numberm)
    {
        Console.WriteLine(item);
    }
}*/


#endregion


#region 3.Çözüm

/*Console.WriteLine("POZİTİF BİR TAM SAYI GİRİNİZ");

int PNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("GİRDİĞİNİZ RAKAM KADAR KELİME GİRİN");

string[] words = new string[PNumber];

for (int i = 0; i < PNumber; i++)
{
    words[i] = Console.ReadLine();
}

words = words.Reverse().ToArray();

Console.WriteLine("Kelimeler sondan başa doğru:");

foreach (var item in words)
{
    Console.WriteLine(item);
}*/

#endregion

#region 4.Çözüm

Console.WriteLine("Bir cümle yazınız:");
string? cumle = Console.ReadLine();


string[] kelimeler = cumle.Split(' ');


Console.WriteLine("Kelime sayısı: " + kelimeler.Length);


int toplamHarfSayisi = 0;
foreach (var kelime in kelimeler)
{
    toplamHarfSayisi += kelime.Length;
}


Console.WriteLine("Toplam harf sayısı: " + toplamHarfSayisi);


#endregion



