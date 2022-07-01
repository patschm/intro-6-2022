using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenbordLib.Vakken
{
    public class Einde : Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op Einde ({Positie}) en is de winnaar");
            p.IsWinnaar = true;
        }
    }
}
