using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenbordLib.Vakken
{
    public class DoornStruik : Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op doornstruik en moet naar vak 37");
            Vak v37 = Bord.FindVak(37);
            p.Verplaats(v37);
        }
    }
}
