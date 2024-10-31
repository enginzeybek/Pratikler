// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int number = 0;

while (number < 11)
{
    number++;

    if (number == 5)
    {
        continue;
    }

    Console.WriteLine(number);

    
}*/

// a'dan z'ye kadar ekrana yaz.

/*char character = 'A';

while (character < 'Z')
{
    character++;
    Console.WriteLine(character);
}*/

int[] numbers = {45,89,5,22,18,96,77};

Array.Sort(numbers);

Array.Reverse(numbers);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}
