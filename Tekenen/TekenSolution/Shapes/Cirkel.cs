using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cirkel: Figuur
    {
        public int Straal { get; set; }

        public override void Teken()
        {
            Console.WriteLine($"Cirkel met straal {Straal} op positie {Positie}");
        }
    }
}
