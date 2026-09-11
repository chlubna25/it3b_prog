class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej velikost pole:"); //vstup 1
        int n = int.Parse(Console.ReadLine());

        int[] pole = new int[n]; //zakladani pole

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Zadej prvek:"); //vstup 2
            pole[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++) //vypocty
        {
            for (int j = i + 1; j < n; j++)
            {
                if (pole[i] < pole[j])
                {
                    int temp = pole[i];
                    pole[i] = pole[j];
                    pole[j] = temp;
                }
            }
        }
        Console.WriteLine("Serazene pole:"); //vystup
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(pole[i]);
        }

    }
}