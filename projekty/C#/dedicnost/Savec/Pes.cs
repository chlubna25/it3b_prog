namespace OOP_Zvirata
{
    public class Pes : Savec
    {

        public Pes(string jmeno; int Energie = 100) : base(jmeno)
        {
            
        }

        public void Zastekej()
        {
            Console.WriteLine($"Pes {Jmeno} štěká");
        }
    }
}