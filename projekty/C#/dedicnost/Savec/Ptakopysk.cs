using System;

// DĚDIČNOST: i ptakopysk je savec, přestože klade vejce.
public class Ptakopysk : Savec
{
    public Ptakopysk(string jmeno) : base(jmeno, 1500)
    {
    }

    public void SnesVajicko()
    {
        Hmotnost -= 2;
        Console.WriteLine($"Ptakopysk {Jmeno} snesl vajíčko. Jeho hmotnost je nyní {Hmotnost} g.");
    }

    // POLYMORFISMUS: ptakopysk vydává jiný zvuk než pes.
    public override void VydatZvuk()
    {
        Console.WriteLine($"Ptakopysk {Jmeno} tiše zavrčí.");
    }
}