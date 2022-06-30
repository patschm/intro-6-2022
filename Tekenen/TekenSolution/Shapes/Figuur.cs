using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Figuur
    {
        public Position Positie { get; set; }

        // virtual maakt het gedrag polymorf-ready, maar een afgeleide class
        // hoeft hem niet te overriden.
        // Wanneer je die override wilt afdwingen, dan verander je virtual in abstract.
        // Dat gaat je wat kosten want daarmee moet jouw hele class abstract worden/
        // Het gevolg daarvan is dat je van Figuur geen instanties meer kan maken.
        // Oftewel: new Figuur() kan niet meer.
        // Kan hem alleen nog gebruiken om te generaliseren (Figuur f = new Cirkel())
        // Abstracte methodes mogen geen implementatie hebben.
        public abstract void Teken();
        //{
        //    Console.WriteLine($"Figuur op positie {Positie}");
        //}
    }
}
