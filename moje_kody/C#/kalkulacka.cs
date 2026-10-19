class Program
{
    static void Main()
    {
        Console.Write("Zadej první číslo: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Zadej operátor (+ - * /): ");
        char op = Console.ReadLine()[0];

        Console.Write("Zadej druhé číslo: ");
        double b = double.Parse(Console.ReadLine());

        double vysledek = 0;

        if (op == '+')
            vysledek = a + b;
        else if (op == '-')
            vysledek = a - b;
        else if (op == '*')
            vysledek = a * b;
        else if (op == '/')
            vysledek = a / b;

        Console.WriteLine($"Výsledek je: " + vysledek);
    }
}
