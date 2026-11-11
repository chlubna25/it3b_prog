using System;

public class Savec
{
    public string Jmeno { get; set; }
    public double Hmotnost { get; set; }

    public Savec(string jmeno, double hmotnost)
    {
        Jmeno = jmeno;
        Hmotnost = hmotnost;
    }

    public void PredstavSe()
    {
        Console.WriteLine($"Jmenuji se {Jmeno} a vážím {Hmotnost} g.");
    }

    // POLYMORFISMUS: potomci mohou tuto metodu přepsat vlastním zvukem.
    public virtual void VydatZvuk()
    {
        Console.WriteLine($"{Jmeno} vydává zvuk.");
    }
}
