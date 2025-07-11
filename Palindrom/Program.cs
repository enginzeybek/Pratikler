// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir kelime giriniz");

string? clientWord = Console.ReadLine();

PalindromeChecker palindromeChecker = new PalindromeChecker();

palindromeChecker.FindPalindromeChecker(clientWord);
