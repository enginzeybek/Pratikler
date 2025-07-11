public class PalindromeChecker
{
    public void FindPalindromeChecker(string Word)
    {
        Word = Word.ToUpper();

        char[] charWord = Word.ToCharArray();

        string? ReverseWord = new string(charWord.Reverse().ToArray());

        string? UpperReverseWord = ReverseWord.ToUpper();

        if (UpperReverseWord == Word)
        {
            Console.WriteLine("GİRDİĞİNİZ KELİME PALİNDROME: " + UpperReverseWord);
        }
        else if (string.IsNullOrWhiteSpace(UpperReverseWord))
        {
            Console.WriteLine("GEÇERLİ BİR KELİME GİRİN");
        }
        else
        {
            Console.WriteLine("GİRDİĞİNİZ KELİME PALİNDROME DEĞİL: " + Word);
        }
    }
}