public class Student
{
    public string Jmeno { get; set; }
    public int Vek { get; set; }
    public string Trida { get; set; }
    public List<int> Znamky;

    public Student(string jmeno, int vek, string trida)
    {
        Jmeno = jmeno;
        Vek = vek;
        Trida = trida;
        Znamky = new List<int>();
    }

    public void PridatZnamku(int novaZnamka)
    {
        Znamky.Add(novaZnamka);
    }

    public void VypisZnamky()
    {
        Console.WriteLine("Znamky studenta:");
        foreach (int z in Znamky)
        {
            Console.WriteLine(" " + z);
        }
    }

    public void SmazZnamku(int znamka)
    {
        Znamky.Remove(znamka);
    }

    public double PrumerZnamek()
    {
        int soucet = 0;

        foreach (int z in Znamky)
        {
            soucet = soucet + z;
        }

        return (double)soucet / Znamky.Count;
    }

    public void VypisInfo()
    {
        Console.WriteLine("--------------------");
        Console.WriteLine("Student:");
        Console.WriteLine("Jmeno: " + Jmeno);
        Console.WriteLine("Vek: " + Vek);
        Console.WriteLine("Trida: " + Trida);

        Console.WriteLine("Znamky:");
        foreach (int z in Znamky)
        {
            Console.Write(z + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Prumer: " + PrumerZnamek());
        Console.WriteLine("Dospely: " + JeDospely());
        Console.WriteLine("--------------------");
    }

    public bool JeDospely()
    {
        return Vek >= 18;
    }
}