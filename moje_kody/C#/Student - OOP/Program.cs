class Program
{
    static void Main()
    { 
        Student borivoj = new Student("Borivoj", 67, "IT67");

        Console.WriteLine("Jmeno: " + borivoj.Jmeno);

        borivoj.PridatZnamku(6);
        borivoj.PridatZnamku(7);

        borivoj.VypisZnamky();

        Student patrik = new Student("Patrik", 17, "IT2B");


    }
}