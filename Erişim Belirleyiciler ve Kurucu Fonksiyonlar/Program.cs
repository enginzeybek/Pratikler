// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Worker worker = new Worker("ENGİN ZEYBEK",32);
Worker worker2 = new Worker('E');

Console.WriteLine(worker.Ad + " " + worker.Yas + " " + worker2.Cinsiyet);

public class Worker
{
    public string? Ad;

    public int Yas;

    public char Cinsiyet;
    public Worker(string ad,int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    public Worker(char cinsiyet)
    {
        Cinsiyet = cinsiyet;
    }
}
