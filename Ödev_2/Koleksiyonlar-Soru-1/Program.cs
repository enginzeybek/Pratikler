using System.Collections;

        ArrayList asal = new ArrayList();
        ArrayList notAsal = new ArrayList();
        
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"{i}. sayıyı giriniz:");
            string? input = Console.ReadLine();
            
            if (!int.TryParse(input, out int sayi) || sayi <= 0)
            {
                Console.WriteLine("Lütfen pozitif ve sayısal bir değer giriniz!");
                i--; // Geçerli giriş yapılmazsa tekrar dene
                continue;
            }

            if (IsPrime(sayi))
                asal.Add(sayi);
            else
                notAsal.Add(sayi);
        }

        // Dizileri sırala ve ters çevir
        asal.Sort(); asal.Reverse();
        notAsal.Sort(); notAsal.Reverse();

        // Asal ve asal olmayanları yazdır
        Console.WriteLine("\nAsal Sayılar: ");
        foreach (int num in asal) Console.Write(num + " ");
        
        Console.WriteLine("\nAsal Olmayan Sayılar: ");
        foreach (int num in notAsal) Console.Write(num + " ");

        // Eleman sayısı ve ortalama hesaplama
        Console.WriteLine($"\n\nAsal Sayılar Eleman Sayısı: {asal.Count}");
        Console.WriteLine($"Asal Sayılar Ortalaması: {CalculateAverage(asal):F2}");
        
        Console.WriteLine($"Asal Olmayan Sayılar Eleman Sayısı: {notAsal.Count}");
        Console.WriteLine($"Asal Olmayan Sayılar Ortalaması: {CalculateAverage(notAsal):F2}");
    
    // Asal sayı kontrolü
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Ortalama hesaplama
    static double CalculateAverage(ArrayList list)
    {
        if (list.Count == 0) return 0;
        int sum = 0;
        foreach (int num in list)
            sum += num;
        return (double)sum / list.Count;
    }