using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekenProgramma
{
    public class Canvas
    {
        private List<Figuur> figuren = new List<Figuur>();

        public void Add(Figuur figuur)
        {
            figuren.Add(figuur);
        }
        public void Refresh(Graphics g)
        {
            foreach(Figuur figuur in figuren)
            {
                figuur.Teken(g);
            }
        }
    }
}
