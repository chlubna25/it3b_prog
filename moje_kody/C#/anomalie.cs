class Program
{
    static int PocetAnomalii(int[] pole)
    {
        int pocet = 0;

        for (int i = 1; i < pole.Length - 1; i++)
        {
            if ((pole[i] > pole[i - 1] && pole[i] > pole[i + 1]) ||
                (pole[i] < pole[i - 1] && pole[i] < pole[i + 1]))
            {
                pocet++;
            }
        }

        return pocet;
    }

    static void Main()
    {
        Console.WriteLine("Zadej velikost pole:");
        int n = int.Parse(Console.ReadLine());

        int[] pole = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Zadej prvek:");
            pole[i] = int.Parse(Console.ReadLine());
        }

        int vysledek = PocetAnomalii(pole);

        Console.WriteLine("Pocet anomalii:");
        Console.WriteLine(vysledek);
    }
}