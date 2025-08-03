// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("Lütfen bir sayı giriniz");

    int sayi = int.Parse(Console.ReadLine());
    
    Number number = new Number();
    
    number.FindEvenOdd(sayi);
}


