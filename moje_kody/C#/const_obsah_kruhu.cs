class Program
{
    static double ObsahKruhu(double r) //funkce
    {
        const double PI = 3.14159;

        return PI * r * r;
    }

    static void Main()
    {
        Console.WriteLine("Zadej mi polomer: "); //vstup
        double polomer = double.Parse(Console.ReadLine());

        Console.WriteLine("Obsah kruhu: " + ObsahKruhu(polomer)); //vystup
        Console.ReadLine();
    }
}