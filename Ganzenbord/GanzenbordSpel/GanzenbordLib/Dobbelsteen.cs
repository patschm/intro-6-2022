using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenbordLib
{
    public class Dobbelsteen
    {
        private Random randomizer = new Random();
        public int Worp;

        public int Gooi()
        {
            Worp = randomizer.Next(1, 7);
            return Worp;
        }
    }
}
