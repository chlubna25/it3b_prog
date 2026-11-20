static class Hrac
{
    static public void Vystup()
    {
        Console.WriteLine("Bojovnik utoci");
    }
    static public void Vystup(int sila)
    {
        Console.WriteLine($"Bojovnik utoci silou {sila}");
    }
    static public void Vystup(string zbran)
    {
        Console.WriteLine($"Bojovnik utoci pomoci zbrane {zbran}");
    }
    static public void Vystup(string zbran, int sila)
    {
        Console.WriteLine($"Bojovnik utoci zbrani {zbran} silou {sila}");
    }
}