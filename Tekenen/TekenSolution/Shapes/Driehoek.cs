using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Driehoek : Figuur
    {
        public int Hoogte { get; set; }
        public int Basis { get; set; }
        public int Hoek { get; set; }

        public override void Teken()
        {
            Console.WriteLine($"Driehoek met basis {Basis}, hoogte {Hoogte} en hoek {Hoek} op positie {Positie}");
        }
    }
}
