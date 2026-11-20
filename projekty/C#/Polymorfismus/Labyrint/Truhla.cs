class Truhla : Mistnost
{
    public override void Aktivuj(Hrac hrac)
    {
        Console.WriteLine("Jsi vedle truhly");
        hrac.Penize += 10;
    }
}