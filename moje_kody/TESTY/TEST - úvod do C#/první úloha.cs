class Program
{
    static bool ObsahujeSixSeven(int cislo) //funkce
    {
        if (cislo == 0) return false;
        while (cislo > 0)
        {
            int cifra = cislo % 10;

            if (cifra == 6 || cifra == 7)
            {
             return true; //vraceni hodnoty true
            }
            cislo /= 10;

        }
        return false; //vraceni hodnoty false
    }

    static void Main() //overeni v mainu
    {
        int vstup = int.Parse(Console.ReadLine());
        Console.WriteLine(ObsahujeSixSeven(vstup));

    }

}
 