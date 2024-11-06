// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 2;
int b = 3;
int c = a + b;

Console.WriteLine("Toplam= " + c);

void topla() {
    int sayi1,sayi2;
    sayi1 = 23;
    sayi2 = 98;
    int toplam = sayi1 + sayi2;
    Console.WriteLine(toplam);
}

topla();

static string birlestir(string kelime1,string kelime2) {
        string birlesmis = string.Concat(kelime1,kelime2);
        return birlesmis;
    }

    string print = birlestir("ENGİN","ZEYBEK");

    Console.WriteLine(print);

    int arttırVeTopla(int number1,int number2) {
        number1++;
        number2++;
        int result = number1 + number2;
        return result;
    }

    int print2 = arttırVeTopla(10,20);

    Console.WriteLine(print2);
   
