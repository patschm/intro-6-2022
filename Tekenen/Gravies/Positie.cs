using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekenProgramma
{
    public class Positie
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set
            {
                if (value >= 0)
                {
                    x = value;
                }
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (value >= 0)
                {
                    y = value;
                }
            }
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
