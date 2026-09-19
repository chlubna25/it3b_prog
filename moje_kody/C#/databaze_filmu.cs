class Program
{
    static void Main()
    {
        List<string> nazvy = new List<string>();
        List<int> hodnoceni = new List<int>();

        bool pokracovat = true;

        while (pokracovat)
        {
            Console.WriteLine("1) Pridej film");
            Console.WriteLine("2) Vypis vsechny filmy");
            Console.WriteLine("3) Najdi podle textu");
            Console.WriteLine("4) Prumer hodnoceni");
            Console.WriteLine("5) Smaz film");
            Console.WriteLine("6) Konec");

            int volba = int.Parse(Console.ReadLine());

            if (volba == 1)
            {
                Console.WriteLine("Zadej nazev:");
                string nazev = Console.ReadLine();

                Console.WriteLine("Zadej hodnoceni:");
                int h = int.Parse(Console.ReadLine());

                nazvy.Add(nazev);
                hodnoceni.Add(h);
            }
            else if (volba == 2)
            {
                for (int i = 0; i < nazvy.Count; i++)
                {
                    Console.WriteLine(nazvy[i] + " - " + hodnoceni[i]);
                }
            }
            else if (volba == 3)
            {
                Console.WriteLine("Zadej text:");
                string text = Console.ReadLine();

                for (int i = 0; i < nazvy.Count; i++)
                {
                    if (nazvy[i].Contains(text))
                    {
                        Console.WriteLine(nazvy[i]);
                    }
                }
            }
            else if (volba == 4)
            {
                int soucet = 0;

                for (int i = 0; i < hodnoceni.Count; i++)
                {
                    soucet = soucet + hodnoceni[i];
                }

                if (hodnoceni.Count > 0)
                {
                    Console.WriteLine((double)soucet / hodnoceni.Count);
                }
            }
            else if (volba == 5)
            {
                Console.WriteLine("Zadej nazev:");
                string smaz = Console.ReadLine();

                for (int i = nazvy.Count - 1; i >= 0; i--)
                {
                    if (nazvy[i] == smaz)
                    {
                        nazvy.RemoveAt(i);
                        hodnoceni.RemoveAt(i);
                    }
                }
            }
            else if (volba == 6)
            {
                pokracovat = false;
            }
        }
    }
}