class Sklad
{
    public string Nazev { get; set; }
    public int MaxKapacita { get; set; }
    private int pocetZbozi;

    public Sklad(string nazev, int maxKapacita)
    {
        Nazev = nazev;
        MaxKapacita = maxKapacita;
        pocetZbozi = 0;
    }

    public int VolneMisto()
    {
        return MaxKapacita - pocetZbozi;
    }

    public void VlozitZbozi(int pocet)
    {
        if (pocet <= VolneMisto())
        {
            pocetZbozi = pocetZbozi + pocet;
        }
    }

    public void OdveztZbozi(int pocet = 1)
    {
        if (pocetZbozi - pocet >= 0)
        {
            pocetZbozi = pocetZbozi - pocet;
        }
    }

    public void VypisInfo()
    {
        Console.WriteLine("Nazev skladu: " + Nazev);
        Console.WriteLine("Kapacita skladu je: " + MaxKapacita);
        Console.WriteLine("Pocet zbozi ve sklade: " + pocetZbozi);
        Console.WriteLine("Volne misto v sklade: " + VolneMisto());
    }
}