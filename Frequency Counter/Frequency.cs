public class Frequency
{
    public void FindFrequency(string Word)
    {
        Dictionary<char, int> FrequencyKeyValue = new Dictionary<char, int>();

        foreach (char c in Word)
        {
            if (FrequencyKeyValue.ContainsKey(c))
            {
                FrequencyKeyValue[c]++;
            }
            else
            {
                FrequencyKeyValue[c] = 1;
            }
        }

        
        foreach (var kvp in FrequencyKeyValue)
        {
            Console.WriteLine($"Harf: {kvp.Key}, Frekans: {kvp.Value}");
        }            
        
    }
}