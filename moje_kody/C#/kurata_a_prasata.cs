class Program
{
    static void Main()
    {
        Console.Write("Zadej celkový počet nohou: ");
        int nohy = int.Parse(Console.ReadLine());

        Console.Write("Zadej počet prasat: ");
        int prasata = int.Parse(Console.ReadLine());

        int kureciNohy = nohy - prasata * 4;
        int kurata = kureciNohy / 2;

        Console.WriteLine("Počet kuřat na farmě: " + kurata);
    }
}
