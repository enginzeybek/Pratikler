// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir Sayı Giriniz");

int number = Convert.ToInt32(Console.ReadLine());

int first = 0;
int second = 1;

Console.Write(first + " " + second + " ");

for (int i = 2; i < number; i++)
{
    int next = first + second;
    Console.Write(next + " ");
    first = second;
    second = next;
}


