class Hrac{
    public int Hp{ get; set;}
    public int Penize {get; set;}
    public bool JeZivy = null;

    public Hrac()
    {
        Hp = 50;
        Penize = 50;
    }
    public void ZiskejPenize(int castka)
    {
        Penize += castka;
        Console.WriteLine($"Ziskal si {castka} penez a mas {Penize} penez");
    }
    

}