using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekenProgramma
{
    public class Figuur
    {
        public Positie Positie { get; set; }

        public virtual void Teken(Graphics g)
        {

        }
    }
}
