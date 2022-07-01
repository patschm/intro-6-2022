using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenbordLib.Vakken
{
    public class Opnieuw: Vak
    {
        public override void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} mag opnieuw gooien");
            int worp = Bord.WerpStenen();
            Vak vnext = Bord.FindVak(Positie + worp);
            p.Verplaats(vnext);
        }
    }
}
