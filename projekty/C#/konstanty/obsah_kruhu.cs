class Program
{
    static double pocitaniobsahu(int polomer)
    {
        const double PI = 3.14159;
        return PI * polomer * polomer;
    }

    static void Main()
    {
        Console.Write("Kolik je polomer: ");
        int polomer = int.Parse(Console.ReadLine());

        Console.WriteLine("Obsah je: " + pocitaniobsahu(polomer));
    }
}