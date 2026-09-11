class Program
{
    static void Main()
    {
        Console.Write("Zadej cislo: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Druha odmocnina: {a * a}");
    }
}
