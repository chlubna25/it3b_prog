class Program
{
    static void Main() //main
    {
        Console.WriteLine("Zadej pocet ovci:"); //vstupy
        int pocetOvci = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadej procento uhynu:");
        double procentoUhynu = double.Parse(Console.ReadLine());

        Console.WriteLine("Zadej pocet mladat:");
        int pocetMladat = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadej pocet let:");
        int pocetLet = int.Parse(Console.ReadLine());

        if (pocetOvci < 0 || pocetLet < 0 || procentoUhynu < 0 || procentoUhynu > 1) //overeni vstupu
        {
            Console.WriteLine("CHYBA");
        }
        else
        {
            for (int i = 1; i <= pocetLet; i++) //vypocty
            {
                double uhynulo = pocetOvci * procentoUhynu;
                pocetOvci = (int)(pocetOvci - uhynulo);
                pocetOvci = pocetOvci + pocetMladat;

                Console.WriteLine("Rok " + i + ": " + pocetOvci); //vystup
            }
        }
    }
}