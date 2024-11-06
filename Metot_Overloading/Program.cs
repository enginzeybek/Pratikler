// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Out parametreler

string sayi = "999";
int outSayi;

bool sonuc = int.TryParse(sayi,out outSayi);

if (sonuc)
{
    Console.WriteLine("BAŞARILI");
}
else {
    Console.WriteLine("BAŞARISIZ");
}

Metotlar metot = new Metotlar();

metot.topla(8,9,out int c);

int data = 89;

metot.ekranaYazdir(data);

public class Metotlar
{
    public void topla(int a,int b,out int c)
    {
        c = a + b;
        Console.WriteLine(c);
    }

    public void ekranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public void ekranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
}
