using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenbordLib.Vakken
{
    public class Vak
    {
        internal Bord Bord {  get; set; }
        public int Positie { get; set; }

        public virtual void Actie(Pion p)
        {
            Console.WriteLine($"{p.Naam} landt op positie {Positie}");
        }   
    }
}
