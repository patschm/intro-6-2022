using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekenProgramma
{
    public class Cirkel : Figuur
    {
        public int Straal { get; set; }

        public override void Teken(Graphics g)
        {
            g.DrawArc(Pens.Black, Positie.X, Positie.Y, Straal, Straal, 0, 360);
        }
    }
}
