public class Faktor
{
    public int Faktoriyel(int number)
    {
        if (number == 1 || number == 0)
        {
            return 1;
        }

        int n = 1;

        for (int i = 2; i <= number; i++)
        {
            n *= i;
        }

        return n;
    }
}