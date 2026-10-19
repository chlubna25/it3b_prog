class Program
{
    static void Smaz(List<int> list, int hodnota)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (list[i] == hodnota)
            {
                list.RemoveAt(i);
            }
        }
    }

    static void Main()
    {
        List<int> list = new List<int>();

        Console.WriteLine("Zadej pocet cisel:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Zadej cislo:");
            list.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Zadej hodnotu ke smazani:");
        int h = int.Parse(Console.ReadLine());

        Smaz(list, h);

        Console.WriteLine("Vysledek:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}