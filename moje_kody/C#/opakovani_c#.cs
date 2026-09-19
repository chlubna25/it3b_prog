class Program
{
    static double Zaokrouhli(double cislo)
    {
        return Math.Round(cislo, 2);
    }

    static void Main()
    {
        Console.Write("Zadej desetinné číslo: ");
        double vstup = double.Parse(Console.ReadLine()); 

        double zaokrouhlene = Zaokrouhli(vstup); 
        Console.WriteLine($"Desetinné číslo je: {zaokrouhlene}"); 
    }
}