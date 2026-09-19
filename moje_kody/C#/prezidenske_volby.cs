class Program
{
    static void Main()
    {
        Console.Write("Zadej pocet hlasu pro kandidata X: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Zadej pocet hlasu pro kandidata Y: ");
        int y = int.Parse(Console.ReadLine());

        int celkem = x + y;

        double procentaX = (double)x / celkem * 100;
        double procentaY = (double)y / celkem * 100;

        Console.WriteLine("Kandidat X má: " + procentaX + " %");
        Console.WriteLine("Kandidat Y má: " + procentaY + " %");
    }
}
