// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir cümle giriniz");

string? sentence = Console.ReadLine();

WCount wCount = new WCount();

int count = wCount.WordCountNumber(sentence);

Console.WriteLine("KELİME SAYISI: " + count);
