class Program
{
    static void Main()
    {
        Console.Write("Zadej prvni stranu trojuhelniku: "); //vstupy
        double vstup1 = double.Parse(Console.ReadLine());

        Console.Write("Zadej druhou stranu trojuhelniku: ");
        double vstup2 = double.Parse(Console.ReadLine());

        Console.Write("Zadej treti stranu trojuhelniku: ");
        double vstup3 = double.Parse(Console.ReadLine());

        bool lze = LzeSestrojitTrojuhlenik(vstup1, vstup2, vstup3); //tvorba boolu

        if (lze)
            Console.WriteLine("Trojúhelník lze sestrojit.");
        else
            Console.WriteLine("Trojúhelník nelze sestrojit.");
    }

    static bool LzeSestrojitTrojuhlenik(double a, double b, double c) //static bool
    {
        if (a <= 0 || b <= 0 || c <= 0)
            return false; //chyba

        return (a + b > c) &&
               (a + c > b) &&
               (b + c > a);
    }
}