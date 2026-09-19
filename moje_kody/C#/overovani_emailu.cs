class Program
{
    static bool JeEmail(string email)
    {
        int pocetZavinacu = 0;
        int poziceZavinace = -1;

        for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    pocetZavinacu++;
                    poziceZavinace = i;
                }
            }

        if (pocetZavinacu != 1 || poziceZavinace == 0)
        {
            return false;
        }

        for (int i = poziceZavinace + 1; i < email.Length; i++)
        {
            if (email[i] == '.')
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        Console.WriteLine("Zadej email:");
        string email = Console.ReadLine();

        if (JeEmail(email))
        {
            Console.WriteLine("Email je platny");
        }
        else
        {
            Console.WriteLine("Email neni platny");
        }
    }
}