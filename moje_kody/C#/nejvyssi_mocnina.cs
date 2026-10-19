class Program
{
    static void Main()
    {
        Console.Write("Zadej cislo N: ");
        int n = int.Parse(Console.ReadLine());

        int mocnina = 1;
        
        while (mocnina <= n)
        {
            mocnina * = 2;
        }

        Console.WriteLine("Nejblizsi vyssi mocnina 2 je: " + mocnina);
    }
}
