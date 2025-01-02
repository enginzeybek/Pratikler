public class TakimUyesi
{
    public int ID { get; set; }
    public string? Ad { get; set; }
}

public class Kart
{
    public string? Baslik { get; set; }
    public string? Icerik { get; set; }
    public int AtananKisiID { get; set; }
    public string? Buyukluk { get; set; }
    public string? Kolon { get; set; } 
}

public class BoardService
{
    private List<Kart> kartlar = new List<Kart>();
    private List<TakimUyesi> takimUyeleri = new List<TakimUyesi>();

    public BoardService()
    {
        
        takimUyeleri.Add(new TakimUyesi { ID = 1, Ad = "Ali" });
        takimUyeleri.Add(new TakimUyesi { ID = 2, Ad = "Ayşe" });
        takimUyeleri.Add(new TakimUyesi { ID = 3, Ad = "Mehmet" });

        
        kartlar.Add(new Kart { Baslik = "Kart 1", Icerik = "İçerik 1", AtananKisiID = 1, Buyukluk = "M", Kolon = "TODO" });
        kartlar.Add(new Kart { Baslik = "Kart 2", Icerik = "İçerik 2", AtananKisiID = 2, Buyukluk = "L", Kolon = "IN PROGRESS" });
        kartlar.Add(new Kart { Baslik = "Kart 3", Icerik = "İçerik 3", AtananKisiID = 3, Buyukluk = "S", Kolon = "DONE" });
    }

    public void KartEkle(Kart yeniKart) => kartlar.Add(yeniKart);

    public void KartGuncelle(string baslik, Kart guncellenmisKart)
    {
        var kart = kartlar.FirstOrDefault(k => k.Baslik == baslik);
        if (kart != null)
        {
            kart.Baslik = guncellenmisKart.Baslik;
            kart.Icerik = guncellenmisKart.Icerik;
            kart.AtananKisiID = guncellenmisKart.AtananKisiID;
            kart.Buyukluk = guncellenmisKart.Buyukluk;
            kart.Kolon = guncellenmisKart.Kolon;
        }
    }

    public void KartSil(string baslik) => kartlar.RemoveAll(k => k.Baslik == baslik);

    public void KartTasi(string baslik, string yeniKolon)
    {
        var kart = kartlar.FirstOrDefault(k => k.Baslik == baslik);
        if (kart != null) kart.Kolon = yeniKolon;
    }

    public void BoardListele()
    {
        foreach (var kolon in new[] { "TODO", "IN PROGRESS", "DONE" })
        {
            Console.WriteLine($"### {kolon} ###");
            foreach (var kart in kartlar.Where(k => k.Kolon == kolon))
            {
                var atanmisKisi = takimUyeleri.FirstOrDefault(t => t.ID == kart.AtananKisiID)?.Ad;
                Console.WriteLine($"Başlık: {kart.Baslik}, İçerik: {kart.Icerik}, Atanan Kişi: {atanmisKisi}, Büyüklük: {kart.Buyukluk}");
            }
        }
    }

    public List<TakimUyesi> TakimUyeleriniGetir() => takimUyeleri;
}

