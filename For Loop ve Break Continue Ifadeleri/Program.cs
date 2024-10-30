// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

for (int i = 0; i <= 10 ; i++) {
    Console.WriteLine(i);
}*/

/*Console.WriteLine("BİR SAYI GİRİNİZ:");
int number = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("TEK SAYILAR AŞAĞIDAKİ GİBİDİR");
Console.WriteLine();

for (int i = 0; i < number; i++)
{
    if (i % 2 == 1)
    {
       Console.WriteLine(i); 
    }
    
}*/

/*Console.WriteLine("BİR SAYI GİRİNİZ");

int number = int.Parse(Console.ReadLine());

Console.WriteLine("ASAL SAYILAR AŞAĞIDAKİ GİBİDİR");

for (int i = 2; i <= number; i++)
{
    bool isPrime = true;

    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(i);
    }
}*/

for (int i = 0; i < 10; i++)
{
    if (i > 4)
    {
        break;
    }
    Console.WriteLine(i);
}

Console.WriteLine("----------------------------");

for (int i = 0; i <= 10 ; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}

Console.WriteLine("-----------------------------");

Random random = new Random();

int x = random.Next(1,101);

Console.WriteLine(x);