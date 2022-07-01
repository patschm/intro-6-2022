using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenbordLib.Vakken
{
    public class Start : Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} is aangemeld op start");
        }
    }
}
