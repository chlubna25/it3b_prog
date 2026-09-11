class Program
{
    static void Main()
    {
        const int KOD = 6767;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Zadej kod:");
            Console.WriteLine();

            int kod = int.Parse(Console.ReadLine());

            if (kod == KOD)
            {
                Console.WriteLine();
                Console.WriteLine("Spravny kod");
                Console.ReadLine();
                break;
            }
            Console.WriteLine();
            Console.WriteLine("Spatny kod");
        }
        Console.WriteLine("Bohuzel jsi heslo nezjistil, hra pro tebe končí!!!");
        Console.ReadLine();
    }
}