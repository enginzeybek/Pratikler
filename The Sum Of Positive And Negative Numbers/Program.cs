// See https://aka.ms/new-console-template for more information
Console.WriteLine("Negatif ve pozitif sayıları virgül ile ayırarak giriniz");
string? strNumbers = Console.ReadLine();

Show show = new Show(strNumbers);
show.Sum();
