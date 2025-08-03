public class Number
{
    public void FindEvenOdd(int sayi)
    {
        if (sayi % 2 == 0)
        {
            Console.WriteLine("BU SAYI ÇİFTTİR");
        }
        else if (sayi % 2 == 1)
        {
            Console.WriteLine("BU SAYI TEKTİR");
        }
        else
        {
            Console.WriteLine("RAKAM HARİCİ GİRİŞ YAPMAYINIZ");
        }
    }
}