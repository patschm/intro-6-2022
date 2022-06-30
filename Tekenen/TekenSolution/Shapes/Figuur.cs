using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Figuur
    {
        public Position Positie { get; set; }

        public virtual void Teken()
        {
            Console.WriteLine($"Figuur op positie {Positie}");
        }
    }
}
