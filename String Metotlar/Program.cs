// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string word = "Dersimiz charp, Hoşgeldiniz";
string word2 = "Dersimiz charp";


Console.WriteLine(word.Length);

Console.WriteLine(word.ToUpper());

Console.WriteLine(word.ToLower());

Console.WriteLine(string.Concat(word," Merhaba!"));

Console.WriteLine(word.CompareTo(word2));

Console.WriteLine(string.Compare(word,word2,true));
Console.WriteLine(string.Compare(word,word2,false));

Console.WriteLine(word.Contains(word2));

Console.WriteLine(word.EndsWith("Hoşgeldiniz"));
Console.WriteLine(word.StartsWith("Dersimiz"));

Console.WriteLine(word.IndexOf('e'));

string word3 = "Dersimiz charp";

string[] word4 = word3.Split(" ");

for (int i = 0; i < word4.Length; i++)
{
    Console.WriteLine(word4[i]); // Her kelimeyi ekrana yazdırır
}

Console.WriteLine(word.Insert(0,"Merhaba "));

Console.WriteLine(word.LastIndexOf('i'));

Console.WriteLine(word + word2.PadLeft(30));

Console.WriteLine(word.Remove(10));

Console.WriteLine(word.Replace("charp","C#"));

Console.WriteLine(word.Substring(4));


