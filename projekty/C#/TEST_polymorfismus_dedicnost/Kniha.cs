public class Kniha
{
    public string Nazev {get; set;}
    public int PocetStran {get; set;}
    public bool JeVypujcena {get; set;}

    public Kniha(string nazev, int pocetstran)
    {
        Nazev = nazev;
        PocetStran = pocetstran;
        JeVypujcena = false;
    }

    public virtual double CasVypujcky()
    {
        return PocetStran * 1.5;
    }
    public void Pujc()
    { 
        JeVypujcena = true;
    }
}
public class OdbornaKniha : Kniha
{
    public OdbornaKniha(string nazev, int pocetstran) :base(nazev, pocetstran)
    {
    }
    public override double CasVypujcky()
    {
        return PocetStran * 2;
    }
}
public class DetskaKniha : Kniha
{
    public DetskaKniha(string nazev, int pocetstran) :base(nazev, pocetstran)
    {
    }
    public override double CasVypujcky()
    {
        return PocetStran + 5;
    }
}
public class KnizniCentrum
{
    public double ZbyvajiciCas {get; set;}
    public List<Kniha> SeznamKnih {get; set;}

    public KnizniCentrum(double zbyvajicicas)
    {
        ZbyvajiciCas = zbyvajicicas;
        SeznamKnih = new List<Kniha>();
    }
    public void Pridej(Kniha kniha)
    {
        SeznamKnih.Add(kniha);
    }
    public void Pridej(string nazev, int pocetstran)
    {
        SeznamKnih.Add(new Kniha(nazev, pocetstran));
    }

    public void SpustMenu()
    {
        foreach(Kniha kniha in SeznamKnih)
        {
            if(kniha.JeVypujcena)
            {
                continue;
            }
            double potrebnyCas = kniha.CasVypujcky();
            if(potrebnyCas <= ZbyvajiciCas)
            {
                ZbyvajiciCas -= potrebnyCas;
                kniha.Pujc();
                Console.WriteLine($"Pujceno: {kniha.Nazev} ({potrebnyCas} min)");
            }
        }
        Console.WriteLine($"Zbyvajici cas: {ZbyvajiciCas} min");
    }
}