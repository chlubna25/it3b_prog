using System;
class Program
{
    static void Main()
    {
        char[] vajicka = { 'z', 'c', 'm' };

        List<char> vysluzka = new List<char>();

        bool pokracovat = true;
        int volba;
        char barva;

        while (pokracovat)
        {
            Console.WriteLine("Moznosti: ");
            Console.WriteLine(" 1) Pridej vajicka");
            Console.WriteLine(" 2) Vypis sebrana vajicka");
            Console.WriteLine(" 3) Vypis ");
            Console.WriteLine(" 4) Ukonci aplikaci");
            Console.WriteLine("Vyber akci:");
            volba = int.Parse(Console.ReadLine());

            if (volba < 1 || volba > 4)
                Console.WriteLine("Neplatna operace");
            else if (volba == 1)
            {
                Console.WriteLine("Zadej barvu vajicka [z,c,m]");
                barva = Console.ReadLine()[0];
                if (!"zcm".Contains(barva))
                    Console.WriteLine("Neplatna barva vajicka");
                else
                    vysluzka.Add(barva);
            }
            else if (volba == 2)
            {
                for (int i = 0; i < vysluzka.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". vajicko: " + vysluzka[i]);
                }
            }
            else if (volba == 3)
            {
                Console.WriteLine("Pocet sebranych vajicek: " + vysluzka.Count);
            }
            else if (volba == 4)
            {
                pokracovat = false;
            }
        }
        Console.WriteLine("Aplikace byla ukoncena!!");
    }
}