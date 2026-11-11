class LecivaFontana : Mistnost
{
    public override void Aktivuj(Hrac hrac)
    {
        Console.WriteLine("Jsi vedle Lecive fontany");
        if (hrac.Penize >= 20)
        {
            hrac.Hp += 20;
            hrac.Penize -= 20;
        }
    }
}