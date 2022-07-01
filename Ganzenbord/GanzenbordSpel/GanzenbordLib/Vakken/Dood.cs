using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenbordLib.Vakken
{
    public class Dood: Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op dood ({Positie}) en moet naar start");
            Vak start = Bord.FindVak(0);
            p.Verplaats(start);
        }
    }
}
