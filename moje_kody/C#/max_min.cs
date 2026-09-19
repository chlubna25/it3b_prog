class Program
{
    static void Main()
    {
        // Vytvoření pole pro 5 desetinných čísel
        double[] pole = new double[5];

        // Cyklus pro načtení hodnot od uživatele
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Zadej {i + 1}. číslo: ");
            double cislo = double.Parse(Console.ReadLine());
            pole[i] = cislo;
        }

        // Zjištění základních statistik o poli
        int delka = pole.Length;
        double max = pole.Max();
        double min = pole.Min();

        // Seřazení pole a jeho obrácení (tzn. od největšího po nejmenší)
        Array.Sort(pole);
        Array.Reverse(pole);

        Console.WriteLine("\nVýpis seřazených čísel:");

        // Výpis všech prvků v poli
        foreach (double prvek in pole)
        {
            Console.WriteLine(prvek);
        }
        
        // Bonus: Výpis statistik
        Console.WriteLine($"\nDélka pole: {delka}");
        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Minimum: {min}");
    }
}
