// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faktöriyel bulunacak sayıyı giriniz");

int sayi = int.Parse(Console.ReadLine());

Faktor faktor = new Faktor();

int result = faktor.Faktoriyel(sayi);

Console.WriteLine("GİRDİĞİNİZ SAYININ FAKTORİYELİ: " + result);
