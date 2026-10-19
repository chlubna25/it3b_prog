class Program
{
    static void Main()
    {
        string spravnyLogin = "admin"; //zadavani loginu
        string spravneHeslo = "1234"; //zadavani hesla

        Console.WriteLine("Zadej login:"); //vstup
        string login = Console.ReadLine();

        Console.WriteLine("Zadej heslo:"); //vstup
        string heslo = Console.ReadLine();

        if (login == spravnyLogin && heslo == spravneHeslo) //overeni
        {
            Console.WriteLine("Prihlaseni uspesne");
        }
        else
        {
            if (login != spravnyLogin)
            {
                Console.WriteLine("Spatny login");
            }
            else
            {
                Console.WriteLine("Spatne heslo");
            }
        }
    }
}