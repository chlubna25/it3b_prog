class Program
{
    static void Main()
    {
        BankovniUcet bezny = new BankovniUcet("Roman", 1000, 0, false);

        bezny.Vlozit(500);
        bezny.Vybrat(200);
        bezny.Vybrat(2000);

        bezny.VypisInfo();

        BankovniUcet sporici = new BankovniUcet("Roman", 5000, 0.05, true);

        sporici.Vlozit(1000);
        sporici.Uroceni();
        sporici.Vybrat(300);

        sporici.VypisInfo();
    }
}