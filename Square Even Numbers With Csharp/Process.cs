public class Process
{
    public void SquareEvens(string Numbers)
    {
        if (string.IsNullOrEmpty(Numbers))
        {
            Console.WriteLine("Lütfen bir rakam giriniz.");
            return;
        }
        string[] strArrays = Numbers.Split(",");
        int[] intArrays = Array.ConvertAll(strArrays, int.Parse);

        List<int> ListNumbers = new List<int>();
        ListNumbers.AddRange(intArrays);

        List<int> EvenOfSquare = new List<int>();

        int square = 0;

        foreach (var item in ListNumbers)
        {
            if (item % 2 == 0)
            {
                square = item * item;
                EvenOfSquare.Add(square);
            }
        }

        if (EvenOfSquare.Count > 0)
        {
            Console.Write($"Çift sayıların kareleri: {string.Join(", ", EvenOfSquare)}");
        }
        else
        {
            Console.WriteLine("Hiç çift sayı yok.");
        }
        
        
    }
}