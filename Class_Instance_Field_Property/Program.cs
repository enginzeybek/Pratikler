// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Order 
{
    public int topla(int sayi1,int sayi2) 
    {
        int result = sayi1 + sayi2; // VARİABLE

        return result;
    }

    public int OrderID { get; set; } // PROPERTY

    private string kelime; // FİELD

    /*PUBLİC=Herkese açık.
      PRİVATE=Sadece tanımlandığı class içinde geçerli.
      İNTERNAL=Aynı proje (assembly) içinde geçerli.
      PROTECTED=Sadece tanımlandığı class ve alt classlardan (inheritance) erişilebilir. */
}
