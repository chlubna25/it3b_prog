class Program
{
    static void SelectionSort(int[] pole) //funkce
    {
        for (int i = 0; i < pole.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < pole.Length; j++)
            {
                if (pole[j] < pole[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = pole[i];
            pole[i] = pole[minIndex];
            pole[minIndex] = temp;
        }
    }

    static void Main() //main
    {
        Console.WriteLine("Zadej pocet cisel:");
        int n = int.Parse(Console.ReadLine());

        int[] pole = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Zadej cislo:");
            pole[i] = int.Parse(Console.ReadLine());
        }

        SelectionSort(pole);

        Console.WriteLine("Serazene pole:");
        for (int i = 0; i < pole.Length; i++)
        {
            Console.WriteLine(pole[i]);
        }
    }
}