class Program
{
    static void Main()
    {
        Console.Write("Zadej pocet prednasek: ");
        int prednasky = int.Parse(Console.ReadLine());
        Console.Write("Zadej pocet seminaru: ");
        int seminare = int.Parse(Console.ReadLine());
        Console.Write("Zadej hodinovou mzdu: ");
        int mzda = int.Parse(Console.ReadLine());


        int hodiny = prednasky * 2 + seminare;
        int vyplata = hodiny * mzda;

        Console.WriteLine($"Ucitelova vyplata je: {vyplata}");
    }
}
