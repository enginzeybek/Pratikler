// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// rekürsif - öz yinemeli
// 3^4 = 3*3*3*3

int result = 1;

for (int i = 1; i < 5; i++)
{
    result *= 3;
}

Console.WriteLine(result);

Islemler islem = new Islemler();

Console.WriteLine(islem.expo(2,2));

// Extension Metotlar
string kelime = "Serel Yereli";
Console.WriteLine(kelime.CheckSpace());

public class Islemler
{
    public int expo(int sayi,int us)
    {
        if (us < 2)
        {
            return sayi;
        }
        else
        {
            return expo(sayi,us - 1) * sayi;
        }
    }
}

public static class Extension
{
    public static bool CheckSpace(this string param)
    {
        return param.Contains(" ");
    }
}
