class Program
{
    static void Main()
    {
        Student borivoj = new Student("Borivoj", 67, "IT67");
        borivoj.PridatZnamku(6);
        borivoj.PridatZnamku(7);

        Student patrik = new Student("Patrik", 17, "IT2B");
        patrik.PridatZnamku(2);
        patrik.PridatZnamku(3);
        patrik.PridatZnamku(1);

        Student adam = new Student("Adam", 19, "IT2A");
        adam.PridatZnamku(1);
        adam.PridatZnamku(1);
        adam.PridatZnamku(2);

        //Vypisy: 
        borivoj.VypisInfo();
        patrik.VypisInfo();
        adam.VypisInfo();
    }
}