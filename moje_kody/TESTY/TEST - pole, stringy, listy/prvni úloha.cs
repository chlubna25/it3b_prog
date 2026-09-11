class Program
{
    static string Veta(string veta)
    {
        string[] slova = veta.Split(' ');
        int max = 0;
        string vysledek = "";

        for (int i = 0; i < slova.Length; i++)
        {
            if (!slova[i].Contains("a") && slova[i].Length > max)
            {
                vysledek = slova[i];
                max = slova[i].Length;
            }
        }

        return vysledek;
    }

    static void Main()
    {
        Console.WriteLine("Zadej vetu:");
        string veta = Console.ReadLine();

        Console.WriteLine(Veta(veta));
    }
}