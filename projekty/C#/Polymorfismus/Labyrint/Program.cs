class Program {
    static void Main()
    {
        Hrac hrac = new Hrac(50);
        List<Mistnost> mistnosti = new List<Mistnost;

        mistnosti.Add(new LecivaFontana());
        mistnosti.Add(new LecivaFontana());
        mistnosti.Add(new LecivaFontana());

        foreach (Mistnost m in mistnosti)
        {
            m.Aktivuj(hrac);

            if (hrac.JeZivy == false)
            {
                Console.WriteLine("Hrac je mrtvy");
                Console.WriteLine("Hra skončila");
                Console.ReadLine();
                return;
            }   
        }

    }
}