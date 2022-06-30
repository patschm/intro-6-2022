using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Canvas
    {
        private List<Figuur> figuren = new List<Figuur>();

        public void Add(Figuur fig)
        {
            figuren.Add(fig);   
        }
        public void Ververs()
        {
            Console.Clear();
            foreach(Figuur fig in figuren)
            {
                fig.Teken();
            }
        }
    }
}
