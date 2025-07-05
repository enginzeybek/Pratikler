// See https://aka.ms/new-console-template for more information
Console.WriteLine("Virgül ile ayırarak tek ve çift sayılar giriniz");

string? numbers = Console.ReadLine();

string[] stringNumbers = numbers.Split(",");

int[] ArrayNumbers = Array.ConvertAll(stringNumbers, int.Parse);

int EvenNumbers = 0;

int OddNumbers = 0;

for (int i = 0; i < ArrayNumbers.Length; i++)
{

    if (ArrayNumbers[i] % 2 == 0)
    {
        EvenNumbers += ArrayNumbers[i];
    }
    else if (ArrayNumbers[i] % 2 == 1)
    {
        OddNumbers += ArrayNumbers[i];
    }
}

Console.WriteLine("TEK SAYILARIN TOPLAMI: " + OddNumbers
+ " " + "ÇİFT SAYILARIN TOPLAMI " + EvenNumbers);

