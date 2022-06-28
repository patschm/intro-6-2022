using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobbelSpel
{
    internal class Dobbelen
    {
        public static void StartDobbelen()
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
    }
}
