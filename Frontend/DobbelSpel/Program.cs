namespace DobbelSpel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelkomScherm();
            StartDobbelen();
            StartDobbelen();
            StartDobbelen();
            StartDobbelen();
            StartDobbelen();
            StartDobbelen();
            VertrekScherm();
        }

        static void VertrekScherm()
        {
            Console.WriteLine("U gaat nu al? Wat jammer.");
        }

        static void StartDobbelen()
        {
            Console.WriteLine("Zullen we gaan dobbelen? (y/n)");
            var answer = Console.ReadLine();
            if (answer == "y")
            {
                // We kunnen gaan dobbelen.
                var worp = WerpStenen();
                Console.WriteLine($"U heeft {worp} gegooid");
            }
        }

        static int WerpStenen()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }

        static void WelkomScherm()
        {
            Console.WriteLine("Welkom bij ons superdobbelspel");
        }
    }
}