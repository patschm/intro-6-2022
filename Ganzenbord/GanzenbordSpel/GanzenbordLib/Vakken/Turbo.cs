using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenbordLib.Vakken
{
    public class Turbo : Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op Turbo");
            if (p.HuidigVak.Positie == 0)
            {
                return;
            }
            int worp = 0;
            foreach(var steen in Bord.stenen)
            {
                worp = worp + steen.Worp;
            }
            Console.WriteLine($"{p.Naam} gaat {worp} posities verder");
            Vak vNext = Bord.FindVak(Positie + worp);
            p.Verplaats(vNext);
        }
    }
}
