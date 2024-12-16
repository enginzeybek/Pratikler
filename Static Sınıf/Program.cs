// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Product.Fruit = "Elma";
Product.Fruit = "Portakal";
Product.Fruit = "Erik";

Product.Vegetables.Add("Ispanak");
Product.Vegetables.Add("Havuç");
Product.Vegetables.Add("Maydanoz");

Product.WriteVegetable();

Product.WriteFruit();

Category category = new Category(8);

Console.WriteLine(Category.Name);

public static class Product
{
    public static string? Fruit { get; set; }

    public static List<String> Vegetables { get; set; } = new List<string>();

    public static void WriteFruit()
    {
        Console.WriteLine("Meyveler= " + Fruit);
    }

    public static void WriteVegetable()
    {
        foreach (var item in Vegetables)
        {
            Console.WriteLine("Sebzeler= " + item);
        }
        
    }
}

public class Category
{
    public static string? Name { get; set; }

    public int Piece { get; set; }
    static Category()
    {
        Name = "Yiyecek";
    }

    public Category(int piece)
    {
        Piece = piece;
    }
}
