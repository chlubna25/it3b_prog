class Nepritel : Mistnost
{
    private static Random nahoda = new Random();

    public override void Aktivuj(Hrac hrac)
    {
        Console.WriteLine("Narazil si na nepritele");
        if (nahoda.Next(0, 2) == 1)
        {
            Console.WriteLine("Vyhral si boj.");
        }
        else
        {
            Console.WriteLine("Prohral jsi.");
            hrac.Hp -= 30;
        }
    }
}