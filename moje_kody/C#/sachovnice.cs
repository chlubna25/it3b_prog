class Program
{
    static void Main()
    {
        Console.Write("Zadej první znak: ");
        char a = Console.ReadLine()[0];

        Console.Write("Zadej druhý znak: ");
        char b = Console.ReadLine()[0];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if ((i + j) % 2 == 0)
                    Console.Write(a);
                else
                    Console.Write(b);
            }
            Console.WriteLine();
        }
    }
}
