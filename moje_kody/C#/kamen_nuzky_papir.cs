using System;

class Program
{
    static void Main()
    {
        Console.Write("Hráč 1 zadej (kamen, nuzky, papir): ");
        string hrac1 = Console.ReadLine().ToLower();

        Console.Write("Hráč 2 zadej (kamen, nuzky, papir): ");
        string hrac2 = Console.ReadLine().ToLower();

        VyhodnotHru(hrac1, hrac2);
    }

    static void VyhodnotHru(string h1, string h2)
    {
        if (h1 == h2)
        {
            Console.WriteLine("Remiza!");
        }
        else if (
            (h1 == "kamen" && h2 == "nuzky") ||
            (h1 == "nuzky" && h2 == "papir") ||
            (h1 == "papir" && h2 == "kamen")
        )
        {
            Console.WriteLine("Vyhral hrac 1!");
        }
        else
        {
            Console.WriteLine("Vyhral hrac 2!");
        }
    }
}