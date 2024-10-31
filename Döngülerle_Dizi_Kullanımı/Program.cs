// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] renkler = new string[5];

renkler[0] = "RED";
renkler[1] = "YELLOW";
renkler[2] = "GREEN";
renkler[3] = "BLUE";
renkler[4] = "PİNK";

string[] hayvanlar = {"DONKEY","CAT","COW","DOG","MOUSE","BAT"};

Console.WriteLine(hayvanlar[2]);

for (int i = 0; i < renkler.Length; i++)
{
    Console.WriteLine(renkler[i]);
}

foreach (var item in hayvanlar)
{
    Console.WriteLine(item);
}
