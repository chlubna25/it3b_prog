class Program
{
    static bool JeDelitel(int d, int c) //funkce
    {
        if (c % d == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static int NSD(int a, int b) //funkce nejvetsi spolecny delitel
    {
        int min;

        if (a < b)
        {
            min = a;
        }
        else
        {
            min = b;
        }

        for (int i = min; i >= 1; i--)
        {
            if (JeDelitel(i, a) && JeDelitel(i, b))
            {
                return i;
            }
        }

        return 1;
    }

    static void Main() //overeni v mainu
    {
        Console.WriteLine("Zadej prvni cislo:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadej druhe cislo:");
        int y = int.Parse(Console.ReadLine());

        int vysledek = NSD(x, y);

        Console.WriteLine("Nejvetsi spolecny delitel je:");
        Console.WriteLine(vysledek);
    }
}
 