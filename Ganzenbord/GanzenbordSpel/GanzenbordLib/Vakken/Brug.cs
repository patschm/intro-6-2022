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
            Vak v12 = Bord.FindVak(12);
            p.Verplaats(v);
        }
    }
}
