class Trida
{
    public string Nazev {  get; set; }
    public Ucitel Tridni { get; set; }
    public Trida(string nazev)
    {
        Nazev = nazev;
        Tridni = null;

    }

    public void PridatTridniho(Ucitel tridni)
    {
        if (Tridni != null)
        {
            Tridni.Tridnictvi = null;
            Tridni.JeTridni = false;
        }

        Tridni = tridni;
        tridni.JeTridni = true;
        tridni.Tridnictvi = this;
    }
}