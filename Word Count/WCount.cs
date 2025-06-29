public class WCount
{
    public int WordCountNumber(string? clientSentence)
    {
        int counter = 0;

        if (string.IsNullOrWhiteSpace(clientSentence))
        {
            return 0;
        }

        string[] splitSentence = clientSentence.Split(" ",StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < splitSentence.Length; i++)
        {
            counter++;
        }

        return counter;
    }
}