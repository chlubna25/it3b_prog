class Utok
{
    public string Nazev { get; set; }
    public int Poskozeni { get; set; }

    public Utok(string nazev, int poskozeni)
    {
        Nazev = nazev;
        Poskozeni = poskozeni;
    }

    public void VypisInfo()
    {
        Console.WriteLine(Nazev + " - poskozeni: " + Poskozeni);
    }
}