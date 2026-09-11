class Program
{
    static void Main()
    {
        Trida it2b = new Trida("IT2B");
        Ucitel petrDrimal = new Ucitel("Petr Drimal");

        it2b.PridatTridniho(petrDrimal);

        Console.WriteLine("Trida: " + it2b.Nazev);
        Console.WriteLine("Tridni ucitel: " + it2b.Tridni.Jmeno);
        Console.WriteLine("Je tridni: " + petrDrimal.JeTridni);
        Console.WriteLine("Tridnictvi: " + petrDrimal.Tridnictvi.Nazev);
    }
}