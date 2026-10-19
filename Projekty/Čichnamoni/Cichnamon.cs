class Cichnamon
{
    public string Jmeno { get; set; }
    public int Zdravi { get; set; }
    public int MaxZdravi { get; set; }
    public Utok ZakladniUtok { get; set; }
    public Utok SpecialniUtok { get; set; }

    public Cichnamon(string jmeno, int zdravi, Utok zakladniUtok, Utok specialniUtok)
    {
        Jmeno = jmeno;
        Zdravi = zdravi;
        MaxZdravi = zdravi;
        ZakladniUtok = zakladniUtok;
        SpecialniUtok = specialniUtok;
    }

    public void Zautoc(Cichnamon protivnik)
    {
        Console.WriteLine(Jmeno + " pouzil " + ZakladniUtok.Nazev);
        protivnik.UberZdravi(ZakladniUtok.Poskozeni);
    }

    public void SpecialniZautoc(Cichnamon protivnik)
    {
        Console.WriteLine(Jmeno + " pouzil " + SpecialniUtok.Nazev);
        protivnik.UberZdravi(SpecialniUtok.Poskozeni);
    }

    public void UberZdravi(int kolik)
    {
        Zdravi = Zdravi - kolik;

        if (Zdravi < 0)
        {
            Zdravi = 0;
        }
    }

    public void Uzdrav(int kolik)
    {
        Zdravi = Zdravi + kolik;

        if (Zdravi > MaxZdravi)
        {
            Zdravi = MaxZdravi;
        }
    }

    public bool JeNazivu()
    {
        return Zdravi > 0;
    }

    public void VypisInfo()
    {
        Console.WriteLine("Cichnamon: " + Jmeno);
        Console.WriteLine("Zdravi: " + Zdravi + "/" + MaxZdravi);
        Console.WriteLine("Zakladni utok: " + ZakladniUtok.Nazev);
        Console.WriteLine("Specialni utok: " + SpecialniUtok.Nazev);
        Console.WriteLine();
    }
}