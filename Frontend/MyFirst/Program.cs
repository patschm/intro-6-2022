namespace MyFirst
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            Console.WriteLine("Welkom bij ons superdobbelspel");
            Console.WriteLine("Zullen we gaan dobbelen? (y/n)");
            var answer = Console.ReadLine();
            if (answer == "y")
            {
                // We kunnen gaan dobbelen.
                var worp = rnd.Next(1, 7);
                Console.WriteLine($"U heeft {worp} gegooid");
            }
            Console.WriteLine("Zullen we gaan dobbelen? (y/n)");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                // We kunnen gaan dobbelen.
                var worp = rnd.Next(1, 7);
                Console.WriteLine($"U heeft {worp} gegooid");
            }
            Console.WriteLine("Zullen we gaan dobbelen? (y/n)");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                // We kunnen gaan dobbelen.
                var worp = rnd.Next(1, 7);
                Console.WriteLine($"U heeft {worp} gegooid");
            }
            Console.WriteLine("Zullen we gaan dobbelen? (y/n)");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                // We kunnen gaan dobbelen.
                var worp = rnd.Next(1, 7);
                Console.WriteLine($"U heeft {worp} gegooid");
            }
            Console.WriteLine("Zullen we gaan dobbelen? (y/n)");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                // We kunnen gaan dobbelen.
                var worp = rnd.Next(1, 7);
                Console.WriteLine($"U heeft {worp} gegooid");
            }
            //else
            //{
            //    Console.WriteLine("Bye!!");
            //}
            Console.WriteLine("Bye!!");
        }
    }
}