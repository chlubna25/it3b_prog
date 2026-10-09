class Program
{
    int Pokuta(List<int> rychlost)
    {
        const int Max_rychlost = 50;
        int pokuta = 0;
        int Pocetpokut = 0;
        
        foreach(int r in rchlost)
        {
            if(r > Max_rychlost)
            {
                pokuta += 500;
                Pocetpokut++;
            }
        }
        if(Pocetpokut > 10)
        {
            pokuta += 1000;
        }
        if(rychlost.Count > 6 && rychlost.Count == Pocetpokut)
        {
            pokuta += 6000;
        }
        return pokuta;
    }

    static void Main()
    {

    }
}