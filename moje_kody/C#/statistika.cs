class Program
{
    static void Main()
    {
        double[] pole = new double[10];
        Console.WriteLine("Zadej 10 cisel:");

        for (int i = 0; i < 10; i++)
        {
            pole[i] = double.Parse(Console.ReadLine());
        }

        double min = pole[0];
        double max = pole[0];

        for (int i = 1; i < 10; i++)
        {
            if (pole[i] < min)
                min = pole[i];

            if (pole[i] > max)
                max = pole[i];
        }

        Console.WriteLine("Maximum: " + max);
        Console.WriteLine("Rozdil min a max: " + (max - min));

        Array.Sort(pole);

        Console.WriteLine("Tri nejnizsi hodnoty:");
        Console.WriteLine(pole[0]);
        Console.WriteLine(pole[1]);
        Console.WriteLine(pole[2]);

        double median = (pole[4] + pole[5]) / 2;

        Console.WriteLine("Median: " + median);
    }
}