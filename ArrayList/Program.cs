// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

ArrayList arrayList = new ArrayList();

arrayList.Add("Salı");
arrayList.Add(52);
arrayList.Add(54.89);
arrayList.Add('A');

for (int i = 0; i < arrayList.Count; i++)
{
    Console.WriteLine(arrayList[i]);
}
string[] renkler = {"kırmızı","sarı","yeşil","mavi"};

List<int> sayilar = new List<int>() {45,89,12,33};

arrayList.AddRange(renkler);

arrayList.AddRange(sayilar);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

arrayList.BinarySearch(45);


