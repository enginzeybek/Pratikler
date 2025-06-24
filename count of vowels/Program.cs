// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir cümle giriniz");

string clientSentence = Console.ReadLine();

Vowels vowels = new Vowels();

int count = vowels.numberOfVowelsCount(clientSentence);

Console.WriteLine("SESLİ HARF SAYISI= " + count);


