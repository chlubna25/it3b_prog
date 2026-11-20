using System;

// DĚDIČNOST: Pes přebírá vlastnosti a chování od třídy Savec.
public class Pes : Savec
{
    public int Energie { get; set; }

    public Pes(string jmeno, int energie = 100) : base(jmeno, 20000)
    {
        Energie = energie;
    }

    public void Zastekej()
    {
        Console.WriteLine($"Pes {Jmeno} štěká.");
    }

    // POLYMORFISMUS: při volání přes typ Savec se použije tato verze.
    public override void VydatZvuk()
    {
        Zastekej();
    }
}
