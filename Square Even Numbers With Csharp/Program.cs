// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen virgülle ayırarak birkaç rakam giriniz");

string NumbersStr = Console.ReadLine();

Process process = new Process();

process.SquareEvens(NumbersStr);
