public class BankovniUcet
{
    public string Majitel { get; set; }
    public double Zustatek { get; set; }
    public double Urok { get; set; }
    public bool Sporici { get; set; }
    public List<string> Historie;

    public BankovniUcet(string majitel, double zustatek, double urok, bool sporici)
    {
        Majitel = majitel;
        Zustatek = zustatek;
        Urok = urok;
        Sporici = sporici;
        Historie = new List<string>();
    }

    public void Vlozit(double castka)
    {
        if (castka > 0)
        {
            Zustatek = Zustatek + castka;
            Historie.Add("Vklad: " + castka);
        }
    }

    public void Vybrat(double castka)
    {
        if (castka > 0 && Zustatek - castka >= 0)
        {
            Zustatek = Zustatek - castka;
            Historie.Add("Vyber: " + castka);
        }
        else
        {
            Console.WriteLine("Nelze vybrat penize");
        }
    }

    public void Uroceni()
    {
        if (Sporici)
        {
            double x = Zustatek * Urok;
            Zustatek = Zustatek + x;
            Historie.Add("Urok: " + x);
        }
    }

    public void VypisHistorii()
    {
        Console.WriteLine("Historie transakci:");
        foreach (string h in Historie)
        {
            Console.WriteLine(h);
        }
    }

    public void VypisInfo()
    {
        Console.WriteLine("--------------------");
        Console.WriteLine("Majitel: " + Majitel);
        Console.WriteLine("Zustatek: " + Zustatek);
        Console.WriteLine("Sporici ucet: " + Sporici);
        Console.WriteLine("Urok: " + Urok);
        VypisHistorii();
        Console.WriteLine("--------------------");
    }
}