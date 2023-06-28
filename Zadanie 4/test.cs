using Zadanie_4;

class test {
    static void Main(){
        // Przykładowe wykorzystanie programu
        var produktSpozywczy = new ProduktSpozywczy(){
            Nazwa = "Banan",
            CenaNetto = 1.6m,
            KrajPochodzenia = "Afryka",
            Kalorie = 88,
            Alergeny = new HashSet<string> { "Brzoza", "Kiwi", "Melon", "Awokado", "Lateks" }
        };
        var wielopak = new Wielopak<ProduktSpozywczy>(){
            Produkt = produktSpozywczy,
            Ilosc = 8,
            CenaNetto = 13
        };
        Console.WriteLine($"Nazwa produktu: {wielopak.Produkt.Nazwa}");
        Console.WriteLine($"Cena brutto wielopaku: {wielopak.CenaBrutto}");
    }
}
