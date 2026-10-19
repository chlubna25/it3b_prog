class Program
{
    static void Main()
    {
        List<string> jmena = new List<string>();
        List<double> body = new List<double>();
        List<int> maxBody = new List<int>();

        bool pokracovat = true;

        while (pokracovat)
        {
            Console.WriteLine("1) Chci zapsat studenta");
            Console.WriteLine("2) Chci vypsat nejlepsiho studenta");
            Console.WriteLine("3) Chci ukoncit program");

            int volba = int.Parse(Console.ReadLine());

            if (volba == 1)
            {
                Console.WriteLine("Zadej jmeno zaka: ");
                string jmeno = Console.ReadLine();

                Console.WriteLine("Zadej pocet bodu:");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Zadej maximalni pocet bodu:");
                int m = int.Parse(Console.ReadLine());

                jmena.Add(jmeno);
                body.Add(b);
                maxBody.Add(m);
            }
            else if (volba == 2)
            {
                int index = 0;
                double max = body[0] / maxBody[0];

                for (int i = 1; i < jmena.Count; i++)
                {
                    double x = body[i] / maxBody[i];

                    if (x > max)
                    {
                        max = x;
                        index = i;
                    }
                }

                Console.WriteLine("Nejlepsim zakem je: (prekvapive) ");
                Console.WriteLine(jmena[index]);
            }
            else if (volba == 3)
            {
                pokracovat = false; // nebo jsem tu mohl dat klasicky return
            }

        }
    }
}