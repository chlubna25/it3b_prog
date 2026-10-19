class Ukol
{
    public string Nazev { get; set; }
    public int Odmena { get; set; }
    public Sklad Sklad { get; set; }
    public Zamestnanec Zamestnanec { get; set; }
    private bool hotovy;

    public Ukol(string nazev, Sklad sklad, int odmena = 100)
    {
        Nazev = nazev;
        Sklad = sklad;
        Odmena = odmena;
        Zamestnanec = null;
        hotovy = false;
    }

    public void OznacitHotovy()
    {
        hotovy = true;
    }

    public bool JeHotovy()
    {
        return hotovy;
    }

    public void VypisInfo()
    {
        Console.WriteLine("Tvuj ukol je: " + Nazev);
        Console.WriteLine("Tvoje odmena je: " + Odmena);
        Console.WriteLine("Nazev skladu: " + Sklad.Nazev);
        Console.WriteLine("Hotovy: " + hotovy);
    }
}