using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenbordLib.Vakken
{
    public class Brug: Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op de brug ({Positie}) en gaat naar vak 12");
            Vak v12 = Bord.FindVak(12);
            p.Verplaats(v12);
        }
    }
}
