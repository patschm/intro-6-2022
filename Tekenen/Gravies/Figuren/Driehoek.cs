using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekenProgramma
{
    public class Driehoek : Figuur
    {
        public int Basis { get; set; }
        public int Hoogte { get; set; }
        public int Hoek { get; set; }

        public override void Teken(Graphics g)
        {
            Point[] points = new Point[3];
            points[0] = new Point(Positie.X, Positie.Y);
            points[1] = new Point(Positie.X + Basis, Positie.Y);
            double hoekRads = Hoek / 2 * Math.PI;
            int delta = (int)(Hoogte / Math.Tan(hoekRads));
            points[2] = new Point(Positie.X + delta, Positie.Y + Hoogte);
           // g.DrawPolygon(Pens.Black, points);
            
        }
    }
}
