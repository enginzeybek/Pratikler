// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Ogrenci ogr = new Ogrenci();

ogr.name = "irem aytepe";

//ogr.county = "AYDIN"; SADECE OKUNABİLİR, DEĞER ATANAMAZ.

Console.WriteLine(ogr.name);


public class Ogrenci
{
    private string? Name;

    private string? County = "TRABZON";
    public string name
    {
        get { return Name; }
        set { Name = value.ToUpper(); }
    }

    public string county
    {
        get => County;
    }
    
}
