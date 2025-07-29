// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir kelime giriniz");

string? clientWord = Console.ReadLine();

Frequency frequency = new Frequency();

frequency.FindFrequency(clientWord);
