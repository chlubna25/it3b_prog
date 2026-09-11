class Program
{
    static void Main()
    {
        int[] pole = { 7, 3, 12, 5, 1, 9 };

        // seřadí pole od nejmenšího
        Array.Sort(pole);

        // otočí pořadí
        Array.Reverse(pole);

        Console.WriteLine("Pole od nejvetsiho:");

        for (int i = 0; i < pole.Length; i++)
        {
            Console.WriteLine(pole[i]);
        }
    }
}