// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] numbers = {10,20,30,40,50,60,70,80,90,100};

Array.Sort(numbers);
Array.Reverse(numbers);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

Array.Clear(numbers,8,2);

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

int index = Array.IndexOf(numbers,40);

Array.Resize<int>(ref numbers,12);

Console.WriteLine(index);
