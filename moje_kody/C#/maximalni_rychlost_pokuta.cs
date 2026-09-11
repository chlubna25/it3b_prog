class Program
{
    static int SpocitejPokutu(List<int> rychlosti)
    {
        const int MAX_RYCHLOST = 50;
        const int POKUTA = 500;
        const int BONUS_POKUTA = 1000;
        const int VELKA_POKUTA = 6000;

        int celkem = 0;
        int pocetNadLimit = 0;

        foreach (int rychlost in rychlosti) //pokuta
        {
            if (rychlost > MAX_RYCHLOST)
            {
                celkem = celkem + POKUTA;
                pocetNadLimit++;
            }
        }

        if (pocetNadLimit > 10) //bonusová pokuta
        {
            celkem = celkem + BONUS_POKUTA;
        }

        if (rychlosti.Count > 6 && pocetNadLimit == rychlosti.Count) //velká pokuta
        {
            celkem = celkem + VELKA_POKUTA;
        }

        return celkem;
    }
}