// See https://aka.ms/new-console-template for more information
Console.WriteLine("Virgülle ayırarak tek ve çift sayılar giriniz");

string? numbers = Console.ReadLine();

string[] NumbersToArray = numbers.Split(",");

int[] StringToIntArray = Array.ConvertAll(NumbersToArray, int.Parse);

AddEvenOddNumbers addEvenOddNumbers = new AddEvenOddNumbers();

addEvenOddNumbers.ListOddEvenNumbers(StringToIntArray);


