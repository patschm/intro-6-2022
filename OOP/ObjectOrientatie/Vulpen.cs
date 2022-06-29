using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientatie
{
    // Vulpen erft van Pen en daarmee krijgt hij de eigenschappen en gedrag
    // van de pen. Erfen doe je met de ':' (inherits, extends)
    // Je kunt maar van 1 classe tegelijk erfen.
    internal class Vulpen : Pen
    {
        private int schrijfCount = 10;
        public int SchrijfCount
        {
            get { return schrijfCount; }
            set { schrijfCount = 10; }
        }
        
        // Met override activeer ik het polymorfisme.
        // Dit kan alleen als de base methode virtual (of abstract)
        public override void Schrijf(string text)
        {
            if (schrijfCount > 0)
            {
                Console.ForegroundColor = Kleur;
                Console.WriteLine($"Vulpen schrijft {text} met lijndikte {Lijndikte}");
                Console.ResetColor();
                schrijfCount--;
            }
            else
            {
                Console.WriteLine("De vulling is op");
            }
        }
    }
}
