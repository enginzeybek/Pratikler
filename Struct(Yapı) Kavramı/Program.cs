// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dikdortgen dikdortgen = new Dikdortgen();

dikdortgen.kisaKenar = 3;
dikdortgen.uzunKenar = 5;

Console.WriteLine("Class alan hesabı= " + dikdortgen.alanHesapla());

//Dikdortgen_struct dikdortgen_Struct = new Dikdortgen_struct();
Dikdortgen_struct dikdortgen_Struct;

dikdortgen_Struct.kisaKenar = 3;
dikdortgen_Struct.uzunKenar = 5;

Console.WriteLine("Struct alan hesabı= " + dikdortgen_Struct.alanHesapla());

public class Dikdortgen
{
    public int kisaKenar;
    public int uzunKenar;

    public long alanHesapla()
    {
        return kisaKenar * uzunKenar;
    }
}

public struct Dikdortgen_struct
{
    public int kisaKenar;
    public int uzunKenar;

    public long alanHesapla()
    {
        return kisaKenar * uzunKenar;
    }
}
