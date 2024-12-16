// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Car car = new Car();

car.Name = "BMW";

car.color = Colors.MAVİ;

Console.WriteLine("Araba= " + car.color + " " + car.Name);

object greet = "Merhaba";

string stGreet = greet.ToString();

Console.WriteLine(greet.GetType());

Console.WriteLine((int)Colors.MAVİ);

public enum Colors
{
    KIRMIZI,
    SARI,
    MAVİ,
    YEŞİL,
    PEMBE,
    SİYAH,
    BEYAZ
}

public class Car
{
    public string? Name;
    public Colors color;
}
