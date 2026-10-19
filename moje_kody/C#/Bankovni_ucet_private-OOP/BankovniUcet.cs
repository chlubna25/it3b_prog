public class BankovniUcet
{
    public string Majitel { get; set; }
    public double Urok { get; set; }
    public bool Sporici { get; set; }

    private double zustatek;
    private string heslo;
    private List<string> historie;

    public BankovniUcet(string majitel, double zustatek, double urok, bool sporici, string heslo)
    {
        Majitel = majitel;
        this.zustatek = zustatek;
        Urok = urok;
        Sporici = sporici;
        this.heslo = heslo;
        historie = new List<string>();
    }

    public void Vlozit(double castka)
    {
        if (castka > 0)
        {
            zustatek = zustatek + castka;
            historie.Add("Vklad: " + castka);
        }
    }

    public void Vybrat(double castka, string zadaneHeslo)
    {
        if (zadaneHeslo == heslo)
        {
            if (castka > 0 && zustatek - castka >= 0)
            {
                zustatek = zustatek - castka;
                historie.Add("Vyber: " + castka);
            }
            else
            {
                Console.WriteLine("Nelze vybrat penize");
            }
        }
        else
        {
            Console.WriteLine("Spatne heslo");
        }
    }

    public void Uroceni()
    {
        if (Sporici)
        {
            double x = zustatek * Urok;
            zustatek = zustatek + x;
            historie.Add("Urok: " + x);
        }
    }

    public void VypisHistorii(string zadaneHeslo)
    {
        if (zadaneHeslo == heslo)
        {
            Console.WriteLine("Historie transakci:");
            foreach (string h in historie)
            {
                Console.WriteLine(h);
            }
        }
        else
        {
            Console.WriteLine("Spatne heslo");
        }
    }

    public void VypisInfo(string zadaneHeslo)
    {
        if (zadaneHeslo == heslo)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Majitel: " + Majitel);
            Console.WriteLine("Zustatek: " + zustatek);
            Console.WriteLine("Sporici ucet: " + Sporici);
            Console.WriteLine("Urok: " + Urok);
            VypisHistorii(zadaneHeslo);
            Console.WriteLine("--------------------");
        }
        else
        {
            Console.WriteLine("Spatne heslo");
        }
    }
}