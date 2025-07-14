public class AddEvenOddNumbers
{
    public void ListOddEvenNumbers(int[] numbers)
    {
        List<int> NumbersList = numbers.ToList();

        List<int> OddList = new List<int>();
        List<int> EvenList = new List<int>();

        for (int i = 0; i < NumbersList.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                EvenList.Add(numbers[i]);
            }
            else if (numbers[i] % 2 == 1)
            {
                OddList.Add(numbers[i]);
            }
        }

        Console.WriteLine($"Tek Sayılar: {string.Join(",", OddList)}, Çift Sayılar: {string.Join(",", EvenList)}");

    }
}