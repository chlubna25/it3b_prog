class Objekt
{
    public string Cena { get; set; }

    public string Popis { get; set; }

    public Objekt(int cena, string popis = "")
    {
        Cena = cena;
        Popis = popis;
    }
    

    
}