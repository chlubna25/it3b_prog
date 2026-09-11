class Program
{
    static void Main()
    {
        BankovniUcet bezny = new BankovniUcet("Roman", 1000, 0, false, "1234");

        bezny.Vlozit(500);
        bezny.Vybrat(200, "1234");
        bezny.Vybrat(2000, "1234");

        bezny.VypisInfo("1234");

        BankovniUcet sporici = new BankovniUcet("Roman", 5000, 0.05, true, "5678");

        sporici.Vlozit(1000);
        sporici.Uroceni();
        sporici.Vybrat(300, "5678");

        sporici.VypisInfo("5678");
    }
}