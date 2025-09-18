public class Show
{
    private readonly string _strNumbers;
    public Show(string strNumbers)
    {
        _strNumbers = strNumbers;
    }
    public void Sum()
    {
        if (string.IsNullOrEmpty(_strNumbers))
        {
            Console.WriteLine("Lütfen rakam giriniz");
            return;
        }

        string[] strNumbersArray = _strNumbers.Split(",");

        int[] intNumbers = Array.ConvertAll(strNumbersArray, int.Parse);

        int positiveSum = 0;
        int negativeSum = 0;

        for (int i = 0; i < intNumbers.Length; i++)
        {
            if (intNumbers[i] < 0)
            {
                negativeSum += intNumbers[i];
            }
            else
            {
                positiveSum += intNumbers[i];
            }
        }

        Console.WriteLine($"Pozitif sayıların toplamı {positiveSum} ve negatif sayıların toplamı {negativeSum}");
    }
}