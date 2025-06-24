public class Vowels
{
    public int numberOfVowelsCount(string sentence)
    {
        sentence = sentence.ToLower();

        int sayac = 0;

        List<char> charsVowels = new List<char>() { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

        /*for (int i = 0; i < charsVowels.Count; i++)
        {
            if (sentence.Contains(charsVowels[i]))
            {
                sayac++;
            }
        }*/

        foreach (char item in sentence)
        {
            if (charsVowels.Contains(item))
            {
                sayac++;
            }
        }

        return sayac;
    }
}