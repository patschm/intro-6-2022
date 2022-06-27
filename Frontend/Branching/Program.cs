namespace Branching
{
    internal class Program
    {
        // Procedure (Main Entry Point)
        static void Main()
        {
            Welkom();
            string choice = KeuzeMenu();
            VoerKeuzeUit(choice);
        }

        // Procedure
        static void VoerKeuzeUit(string keuze)
        {
            int a =  GeefGetal("A");
            int b = GeefGetal("B");
            if (keuze == "a") Console.WriteLine($"{a + b}");
            if (keuze == "b") Console.WriteLine($"{a - b}");
        }

        // Function
        static int GeefGetal(string v)
        {
            Console.WriteLine($"Geeft getal {v}");
            string sn = Console.ReadLine();
            return int.Parse(sn);
        }

        // Function
        static string KeuzeMenu()
        {
            Console.WriteLine("Wat gaan we doen?");
            Console.WriteLine("a) Optellen");
            Console.WriteLine("b) Aftrekken");
            string keuze = Console.ReadLine();
            return keuze;
        }

        // Procedure
        static void Welkom()
        {
            Console.WriteLine("Goededag. Leuk u weer te zien");
            Console.WriteLine("Wat uw naam?");
            string naam = Console.ReadLine();
            Console.WriteLine($"Hallo {naam}");
        }

      
    }
}