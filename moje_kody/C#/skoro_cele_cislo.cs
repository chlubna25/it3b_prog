class Program
{
    static void Main()
    {
        Console.Write("Zadej desetinne cislo N: "); //vstup
        double N = double.Parse(Console.ReadLine());

        Console.Write("Zadej odchylku epsilon: ");
        double epsilon = double.Parse(Console.ReadLine());

        bool vysledek = JeSkoroCele(N, epsilon); //tvorba boolu

        if (vysledek)
            Console.WriteLine("Cislo je skoro cele.");
        else
            Console.WriteLine("Cislo neni skoro cele.");
    }

    static bool JeSkoroCele(double N, double epsilon) //static bool
    {
        double nejblizsiCele = Math.Round(N);
        double rozdil = Math.Abs(N - nejblizsiCele);

        return rozdil < epsilon;
    }
}