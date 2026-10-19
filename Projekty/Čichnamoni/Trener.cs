class Trener
{
    public string Jmeno { get; set; }
    public int Level { get; set; }
    public List<Cichnamon> Cichnamoni { get; set; }
    public Cichnamon Vybrany { get; set; }

    public Trener(string jmeno)
    {
        Jmeno = jmeno;
        Level = 1;
        Cichnamoni = new List<Cichnamon>();
        Vybrany = null;
    }

    public void PridatCichnamona(Cichnamon c)
    {
        Cichnamoni.Add(c);
    }

    public void VyberCichnamona(int index)
    {
        Vybrany = Cichnamoni[index];
    }

    public void VypisCichnamony()
    {
        for (int i = 0; i < Cichnamoni.Count; i++)
        {
            Console.WriteLine((i + 1) + ") " + Cichnamoni[i].Jmeno);
        }
    }

    public void ZvysLevel()
    {
        Level = Level + 1;
    }

    public void VypisInfo()
    {
        Console.WriteLine("Trener: " + Jmeno);
        Console.WriteLine("Level: " + Level);
    }
}