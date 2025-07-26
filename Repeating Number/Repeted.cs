public class Repeted
{
    public void RNumber(string strValue)
    {
        if (string.IsNullOrWhiteSpace(strValue))
        {
            Console.WriteLine("LÜTFEN RAKAM GİRİNİZ");
            return;
        }
        string[] strArrayValue = strValue.Split(",");

        int[] intArrayValue;

        try
        {
            intArrayValue = Array.ConvertAll(strArrayValue, int.Parse);
        }
        catch
        {
            Console.WriteLine("Lütfen sadece sayılar ve virgül ile ayırınız.");
            return;
        }

        for (int i = 0; i < intArrayValue.Length; i++)
        {
            for (int j = i + 1; j < intArrayValue.Length; j++)
            {
                if (intArrayValue[i] == intArrayValue[j])
                {
                    Console.WriteLine("Tekrar eden sayı: " + intArrayValue[i]);
                    return;  
                }
            }
        }
    }
}