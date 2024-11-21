// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> sayilar = new List<int>();

sayilar.Add(10);
sayilar.Add(20);
sayilar.Add(30);
sayilar.Add(40);
sayilar.Add(50);

for (int i = 0; i < sayilar.Count; i++)
{
    Console.WriteLine(sayilar[i]);
}

List<string> renkler = new List<string> { "sarı", "kırmızı", "mavi", "yeşil" };

renkler.ForEach(x => Console.WriteLine(x));

renkler.Remove("mavi");

renkler.ForEach(x => Console.WriteLine(x));

sayilar.RemoveAt(0);

sayilar.ForEach(y => Console.WriteLine(y));

var value = sayilar.Contains(20);

Console.WriteLine("Bu rakam var: " + value);

Console.WriteLine(sayilar.BinarySearch(30));

int[] rakamlar = { 15, 30, 45, 60 };

// Diziyi listeye dönüştür
var rakamlarList = rakamlar.ToList();

// Dizi türünü kontrol et
var value1 = rakamlar.GetType();
Console.WriteLine("DİZİ VERİ TİPİ: " + value1);

// Liste türünü kontrol et
var value2 = rakamlarList.GetType();
Console.WriteLine("LİSTE VERİ TİPİ: " + value2);

Kullaniciler kullaniciler1 = new Kullaniciler();

Console.WriteLine(kullaniciler1.Isim = "Engin");
Console.WriteLine(kullaniciler1.Soyisim = "Zeybek");
Console.WriteLine(kullaniciler1.Yas = 50);

List<Kullaniciler> kullanicilersList = new List<Kullaniciler>();

kullanicilersList.Add(kullaniciler1);

foreach (var item in kullanicilersList)
{
    Console.WriteLine($"İsim: {item.Isim}, Soyisim: {item.Soyisim}, Yaş: {item.Yas}");
}


public class Kullaniciler
{
    private string? isim;

    private string? soyisim;

    private int yas;

    public string? Isim { get => isim; set => isim = value?.ToUpper(); }
    public string? Soyisim { get => soyisim; set => soyisim = value?.ToLower(); }
    public int Yas
{
    get => yas;
    set
    {
        if (value >= 1 && value <= 100)
        {
            yas = value;
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Yaş 1 ile 100 arasında olmalıdır.");
        }
    }
}
}