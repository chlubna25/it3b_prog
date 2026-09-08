using System;

class Program
{
    static void Main()
    {
        const int CISELNYKOD = 1234;
        int pocetpokusu = 0;

        while (true)
        {
            if (pocetpokusu < 5)
            {
                Console.WriteLine("Zadej ciselny kod: ");
                int vstup = int.Parse(Console.ReadLine());

                if (CISELNYKOD == vstup)
                {
                    Console.WriteLine("Zadal si spravny kod.");
                    break;
                }
                else
                {
                    pocetpokusu++;
                }
            }
            else
            {
                Console.WriteLine("Pekrocen pocet pokusu.");
                break;
            }
        }
    }
}