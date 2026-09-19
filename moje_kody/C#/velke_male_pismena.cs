class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej text:");
        string text = Console.ReadLine();

        Console.WriteLine("Zadej pismeno:");
        char znak = Console.ReadLine()[0];

        int male = 0;
        int velke = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == znak)
            {
                male++;
            }
            if (text[i] == Char.ToUpper(znak))
            {
                velke++;
            }
        }

        if (male > velke)
        {
            Console.WriteLine("Vice malych");
        }
        else if (velke > male)
        {
            Console.WriteLine("Vice velkych");
        }
        else
        {
            Console.WriteLine("Stejne");
        }
    }
}