class Zamestnanec
{
    public string Jmeno { get; set; }
    private int vyplata;
    public List<Ukol> Ukoly { get; set; }

    public Zamestnanec(string jmeno)
    {
        Jmeno = jmeno;
        vyplata = 0;
        Ukoly = new List<Ukol>();
    }

    public void PridatUkol(Ukol ukol)
    {

    }

    public void DokoncitUkol(int index)
    {

    }

    public int Vyplatit()
    {

    }
}