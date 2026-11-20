public class Dum : Objekt
{
    public int VymeraZahrady { get; set; }
    public int PocetPater { get; set; }

    public Dum(int VymeraZahrady, int PocetPater, int cena, string popis = "") : base(cena, popis)
    {
        VymeraZahrady = vymeraZahrady;
        PocetPater = pocetPater;
    }
    public void VypisInfo()
    {
        Console.WriteLine($"Popis: {Popis}");
        Console.WriteLine($"Pocet pater: {Popis}");
    }

}