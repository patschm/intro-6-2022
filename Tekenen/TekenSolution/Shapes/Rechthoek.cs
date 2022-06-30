using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public  class Rechthoek: Figuur
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public override void Teken()
        {
            Console.WriteLine($"Rechthoek met hoogte {Hoogte} en breedte {Breedte} op positie {Positie}");
        }
    }
}
