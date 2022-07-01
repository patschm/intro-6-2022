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
            Console.WriteLine($"{p.Naam} landt op Turbo ({Positie})");
            int worp = 0;
            foreach (var steen in Bord.stenen)
            {
                worp = worp + steen.Worp;
            }
            if (p.HuidigVak.Positie == 0 && worp == 9)
            {
                Console.WriteLine($"{p.Naam} gaat naar 10");
                Vak vNext2 = Bord.FindVak(10);
                p.Verplaats(vNext2);
                return;
            }
            
            Console.WriteLine($"{p.Naam} gaat {worp} posities verder");
            Vak vNext = Bord.FindVak(Positie + worp);
            p.Verplaats(vNext);
        }
    }
}
